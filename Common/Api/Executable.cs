using System.Collections.Generic;
using System.IO;

namespace Avanade.Amp.Common.Api
{
    public enum ExecutableType
    {
        Probe,
        Percolator,
        Trigger
    }

    public abstract class Executable
    {
        protected ExecutingFile _executingFile;

        public IExecutableContent Content { get; set; }

        public Executable(ExecutingFile file)
        {
            _executingFile = file;
        }

        public abstract ExecutionData SetExecutionData();

        protected virtual void AddExternalFileContent(IDictionary<string, object> propertyBag)
        {
            if (_executingFile != null)
            {
                string filePath = _executingFile.FileName;
                int index = filePath.LastIndexOf("\\");
                if (index >= 0)
                {
                    string folder = filePath.Substring(0, index);
                    if (!string.IsNullOrWhiteSpace(folder))
                    {
                        if (!folder.EndsWith("\\"))
                        {
                            folder += "\\";
                        }
                        //todo: read this from a config file or other external
                        string[] fileExtensions = new string[] { ".js", ".json", ".ps1", ".wql", ".sql" };
                        foreach (string key in propertyBag.Keys)
                        {
                            if (propertyBag[key].GetType() == typeof(string) && ((string)propertyBag[key]).Trim() == "")
                            {
                                for (int i = 0; i < fileExtensions.Length; i++)
                                {
                                    string file = folder + key + fileExtensions[i];
                                    if (File.Exists(file))
                                    {
                                        propertyBag[key] = File.ReadAllText(file);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        protected string SetExecutableName()
        {
            //find [executable]\[currentFile]
            return GetParentFolderName("\\");
        }

        protected string SetBundleName()
        {
            //find [bundle]\probes\[probe]\[..\][currentFile]
            return GetParentFolderName("\\probes");
        }

        protected string SetDocumentType(string entities)
        {
            //find ["percolators"|"triggers"]\..\[currentFile]
            return GetParentFolderName("\\" + entities);
        }

        protected string GetParentFolderName(string match)
        {
            if (_executingFile != null)
            {
                string filePath = _executingFile.FileName;
                int index = filePath.LastIndexOf(match);
                if (index >= 0)
                {
                    string folder = filePath.Substring(0, index);
                    if (folder.Trim() != "")
                    {
                        index = folder.LastIndexOf("\\");
                        string name = folder.Substring(index + 1);
                        if (name.Trim() != "")
                        {
                            return name;
                        }
                    }
                }
            }

            return "";
        }
    }
}
