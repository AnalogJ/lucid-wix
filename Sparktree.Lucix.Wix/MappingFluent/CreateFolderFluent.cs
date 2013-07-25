using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class CreateFolderFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private CreateFolder _create;

        public CreateFolderFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement create)
            : base(create)
        {
            _create = create as CreateFolder;
        }
        public CreateFolderFluent Directory(String dir)
        {
            _create.Directory = dir;
            return this;
        }

    }
}
