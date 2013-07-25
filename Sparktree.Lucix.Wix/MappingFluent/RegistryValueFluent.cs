using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class RegistryValueFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private MappingModel.RegistryValue _reg;

        public RegistryValueFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement reg)
            : base(reg)
        {
            _reg = reg as MappingModel.RegistryValue;
        }
        public RegistryValueFluent Action(RegistryValue.ActionType field)
        {
            _reg.Action = field;
            return this;
        }
        public RegistryValueFluent Id(String field)
        {
            _reg.Id = field;
            return this;
        }
        public RegistryValueFluent Key(String field)
        {
            _reg.Key = field;
            return this;
        }
        public RegistryValueFluent KeyPath(Boolean field)
        {
            _reg.KeyPath = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public RegistryValueFluent Name(String field)
        {
            _reg.Name = field;
            return this;
        }
        public RegistryValueFluent Root(RegistryRootType field)
        {
            _reg.Root = field;
            return this;
        }
        public RegistryValueFluent Type(RegistryValue.TypeType field)
        {
            _reg.Type = field;
            return this;
        }
        public RegistryValueFluent Value(String field)
        {
            _reg.Value = field;
            return this;
        }
    }
}
