using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ShortcutFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private MappingModel.Shortcut _shortcut;

        public ShortcutFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement shortcut)
            : base(shortcut)
        {
            _shortcut = shortcut as MappingModel.Shortcut;
        }
        public ShortcutFluent Advertise(Boolean field)
        {
            _shortcut.Advertise = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public ShortcutFluent Arguments(String field)
        {
            _shortcut.Arguments = field;
            return this;
        }
        public ShortcutFluent Description(String field)
        {
            _shortcut.Description = field;
            return this;
        }
        public ShortcutFluent Directory(String field)
        {
            _shortcut.Directory = field;
            return this;
        }
        public ShortcutFluent Hotkey(Int32 field)
        {
            _shortcut.Hotkey = field;
            return this;
        }
        public ShortcutFluent Icon(String field)
        {
            _shortcut.Icon = field;
            return this;
        }
        public ShortcutFluent Id(String field)
        {
            _shortcut.Id = field;
            return this;
        }
        public ShortcutFluent IconIndex(Int32 field)
        {
            _shortcut.IconIndex = field;
            return this;
        }
        public ShortcutFluent LongName(String field)
        {
            _shortcut.LongName = field;
            return this;
        }
        public ShortcutFluent Name(String field)
        {
            _shortcut.Name = field;
            return this;
        }
        public ShortcutFluent ShortName(String field)
        {
            _shortcut.ShortName = field;
            return this;
        }
        public ShortcutFluent Show(Shortcut.ShowType field)
        {
            _shortcut.Show = field;
            return this;
        }
        public ShortcutFluent Target(String field)
        {
            _shortcut.Target = field;
            return this;
        }
        public ShortcutFluent WorkindDirectory(String field)
        {
            _shortcut.WorkingDirectory = field;
            return this;
        }

    }
}
