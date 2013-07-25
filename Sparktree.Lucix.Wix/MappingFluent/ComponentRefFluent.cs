using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using ComponentRef = Sparktree.Lucid.Wix.MappingModel.ComponentRef;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ComponentRefFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private ComponentRef _compRef;

        public ComponentRefFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement compRef)
            : base(compRef)
        {
            _compRef = compRef as ComponentRef;
        }
        public ComponentRefFluent Id(String id)
        {
            _compRef.Id = id;
            return this;
        }
        public ComponentRefFluent Primary(Boolean primary)
        {
            _compRef.Primary = Utilities.YesNoTypeConvert<YesNoType>(primary);
            return this;
        }
    }
}
