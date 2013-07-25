using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class PackageGroupFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private PackageGroup _packageGrp;

        public PackageGroupFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement packageGrp)
            : base(packageGrp)
        {
            _packageGrp = packageGrp as PackageGroup;
        }
        public PackageGroupFluent Id(String id)
        {
            _packageGrp.Id = id;
            return this;
        }
        public PackageGroupFluent IdByName(String productName)
        {
            _packageGrp.Id = Utilities.GeneratePackageId(productName);
            return this;
        }

    }
}
