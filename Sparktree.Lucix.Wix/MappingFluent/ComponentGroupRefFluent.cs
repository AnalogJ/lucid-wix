using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using ComponentGroupRef = Sparktree.Lucid.Wix.MappingModel.ComponentGroupRef;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ComponentGroupRefFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private ComponentGroupRef _compGrpRef;

        public ComponentGroupRefFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement compGrpRef)
            : base(compGrpRef)
        {
            _compGrpRef = compGrpRef as ComponentGroupRef;
        }
        public ComponentGroupRefFluent Id(String id)
        {
            _compGrpRef.Id = id;
            return this;
        }
        public ComponentGroupRefFluent Primary(Boolean primary)
        {
            _compGrpRef.Primary = Utilities.YesNoTypeConvert<YesNoType>(primary);
            return this;
        }


    }
}
