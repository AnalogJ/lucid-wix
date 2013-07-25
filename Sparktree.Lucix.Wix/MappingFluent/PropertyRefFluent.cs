using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class PropertyRefFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private PropertyRef _prop;

        public PropertyRefFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement prop)
            : base(prop)
        {
            _prop = prop as PropertyRef;
        }
        public PropertyRefFluent Id(String field)
        {
            _prop.Id = field;
            return this;
        }

    }
}
