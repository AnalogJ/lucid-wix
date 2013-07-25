using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class DirectoryRefFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private DirectoryRef _dir;

        public DirectoryRefFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement dir)
            : base(dir)
        {
            _dir = dir as DirectoryRef;
        }
        public DirectoryRefFluent DiskId(String disk)
        {
            _dir.DiskId = disk;
            return this;
        }
        public DirectoryRefFluent FileSource(String filesource)
        {
            _dir.FileSource = filesource;
            return this;
        }
        public DirectoryRefFluent Id(String id)
        {
            _dir.Id = id;
            return this;
        }
        

    }
}
