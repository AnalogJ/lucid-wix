using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ComboBoxFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private ComboBox _combo;

        public ComboBoxFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement combo)
            : base(combo)
        {
            _combo = combo as ComboBox;
        }
        public ComboBoxFluent Property(String property)
        {
            _combo.Property = property;
            return this;
        }

    }
}
