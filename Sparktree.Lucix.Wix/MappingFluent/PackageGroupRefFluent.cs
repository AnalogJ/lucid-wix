using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class PackageGroupRefFluent: BaseSchemaFluent, IBaseSchemaFluent,  IBaseSetAttributesFluent
    {
        private PackageGroupRef _packageGrp;

        public PackageGroupRefFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement packageGrp)
            : base(packageGrp)
        {
            _packageGrp = packageGrp as PackageGroupRef;
        }
        public PackageGroupRefFluent After(String field)
        {
            if(!String.IsNullOrEmpty(field))
            {
                _packageGrp.After = field;
            }
            return this;
        }
        public PackageGroupRefFluent Id(String id)
        {
            _packageGrp.Id = id;
            return this;
        }
        public PackageGroupRefFluent IdByName(String productName)
        {
            _packageGrp.Id = Utilities.GeneratePackageId(productName);
            return this;
        }
    }
}
