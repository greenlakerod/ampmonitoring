// Copyright © 2015 - Avanade Inc.

namespace Avanade.Amp.Core.Site
{
    public class ElasticClusterNode
    {
        public string Host { get; set; }
        public NodeFileSystem fs { get; set; }
    }

    public class NodeFileSystem
    {
        public NodeFileSystemTotal total { get; set; }
    }

    public class NodeFileSystemTotal
    {
        public long total_in_bytes { get; set; }
        public long free_in_bytes { get; set; }
    }
}