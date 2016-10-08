namespace Avanade.Amp.Core.Package
{
    public class PackageBlob
    {
        public PackageBlob(Package package)
        {
            Name = $"{package.Name}.{package.Version}.{package.Extension}";
        }

        public string Name { get; set; }
    }
}
