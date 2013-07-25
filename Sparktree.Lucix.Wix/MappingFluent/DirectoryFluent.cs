using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class DirectoryFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Directory _dir;

        public DirectoryFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement dir)
            : base(dir)
        {
            _dir = dir as Directory;
        }
        public DirectoryFluent ComponentGuidGenerationSeed(String genSeed)
        {
            _dir.ComponentGuidGenerationSeed = genSeed;
            return this;
        }
        public DirectoryFluent DiskId(String diskId)
        {
            _dir.DiskId = diskId;
            return this;
        }
        public DirectoryFluent FileSource(String fileSource)
        {
            _dir.FileSource = fileSource;
            return this;
        }
        public DirectoryFluent Id(String id)
        {
            _dir.Id = id;
            return this;
        }
        public DirectoryFluent LongName(String longName)
        {
            _dir.LongName = longName;
            return this;
        }
        public DirectoryFluent LongSource(String longSource)
        {
            _dir.LongSource = longSource;
            return this;
        }
        public DirectoryFluent Name(String name)
        {
            _dir.Name = name;
            return this;
        }
        public DirectoryFluent ShortName(String shortname)
        {
            _dir.ShortName = shortname;
            return this;
        }
        public DirectoryFluent ShortSourceName(String shortsourcename)
        {
            _dir.ShortSourceName = shortsourcename;
            return this;
        }
        public DirectoryFluent SourceName(String sourceName)
        {
            _dir.SourceName = sourceName;
            return this;
        }
        public DirectoryFluent Src(String src)
        {
            _dir.src = src;
            return this;
        }
    }
}
