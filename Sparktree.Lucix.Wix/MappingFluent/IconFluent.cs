using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class IconFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Icon _icon;

        public IconFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement icon)
            : base(icon)
        {
            _icon = icon as Icon;
        }
        public IconFluent Id(String field)
        {
            _icon.Id = field;
            return this;
        }
        public IconFluent SourceFile(String field)
        {
            _icon.SourceFile = field;
            return this;
        }
    }
}
