using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class BinaryRefFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private BinaryRef _binref;

        public BinaryRefFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement binRef)
            : base(binRef)
        {
            _binref = binRef as BinaryRef;
        }
        public BinaryRefFluent Id(String id)
        {
            _binref.Id = id;
            return this;
        }
        public BinaryRefFluent IdByName(String binaryFileName)
        {
            _binref.Id = Utilities.GeneratePackageId(binaryFileName);
            return this;
        }
    }
}
