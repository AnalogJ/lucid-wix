using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Property = Sparktree.Lucid.Wix.MappingModel.Property;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class PropertyFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Property _property;

        public PropertyFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement prop)
            : base(prop)
        {
            _property = prop as Property;
        }
        public PropertyFluent Admin(Boolean field)
        {
            _property.Admin = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public PropertyFluent ComplianceCheck(Boolean field)
        {
            _property.ComplianceCheck = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public PropertyFluent Hidden(Boolean field)
        {
            _property.Hidden = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public PropertyFluent Id(String field)
        {
            _property.Id = field;
            return this;
        }
        public PropertyFluent Secure(Boolean field)
        {
            _property.Secure = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public PropertyFluent SuppressModularization(Boolean field)
        {
            _property.SuppressModularization = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public PropertyFluent Value(String field)
        {
            _property.Value = field;
            return this;
        }
    }
}
