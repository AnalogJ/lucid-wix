using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Control = Sparktree.Lucid.Wix.MappingModel.Control;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ControlFluent : BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Control _control;

        public ControlFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement control)
            : base(control)
        {
            _control = control as Control;
        }
        public ControlFluent Bitmap(Boolean bitmap)
        {
            _control.Bitmap = Utilities.YesNoTypeConvert<YesNoType>(bitmap);
            return this;
        }
        public ControlFluent Cancel(Boolean cancel)
        {
            _control.Cancel = Utilities.YesNoTypeConvert<YesNoType>(cancel);
            return this;
        }
        public ControlFluent CheckBoxPropertyRef(String checkBox)
        {
            _control.CheckBoxPropertyRef = checkBox;
            return this;
        }
        public ControlFluent CheckBoxValue(String checkBox)
        {
            _control.CheckBoxValue = checkBox;
            return this;
        }
        public ControlFluent ComboList(Boolean comboList)
        {
            _control.ComboList = Utilities.YesNoTypeConvert<YesNoType>(comboList);
            return this;
        }
        public ControlFluent Default(Boolean def)
        {
            _control.Default = Utilities.YesNoTypeConvert<YesNoType>(def);
            return this;
        }
        public ControlFluent Disabled(Boolean dis)
        {
            _control.Disabled = Utilities.YesNoTypeConvert<YesNoType>(dis);
            return this;
        }
        public ControlFluent ElevationShield(Boolean elevationShield)
        {
            _control.ElevationShield = Utilities.YesNoTypeConvert<YesNoType>(elevationShield);
            return this;
        }
        public ControlFluent Fixed(Boolean fix)
        {
            _control.Fixed = Utilities.YesNoTypeConvert<YesNoType>(fix);
            return this;
        }
        public ControlFluent FixedSize(Boolean fixedSize)
        {
            _control.FixedSize = Utilities.YesNoTypeConvert<YesNoType>(fixedSize);
            return this;
        }
        public ControlFluent HasBorder(Boolean hasBorder)
        {
            _control.HasBorder = Utilities.YesNoTypeConvert<YesNoType>(hasBorder);
            return this;
        }
        public ControlFluent Height(Int32 height)
        {
            _control.Height = height.ToString();
            return this;
        }
        public ControlFluent Help(String help)
        {
            _control.Help = help;
            return this;
        }
        public ControlFluent Hidden(Boolean hidden)
        {
            _control.Hidden = Utilities.YesNoTypeConvert<YesNoType>(hidden);
            return this;
        }
        public ControlFluent Icon(Boolean icon)
        {
            _control.Icon = Utilities.YesNoTypeConvert<YesNoType>(icon);
            return this;
        }
        public ControlFluent IconSize(Microsoft.Tools.WindowsInstallerXml.Serialize.Control.IconSizeType iconSize)
        {
            _control.IconSize = iconSize;
            return this;
        }
        public ControlFluent Id(String id)
        {
            _control.Id = id;
            return this;
        }
        public ControlFluent Image(Boolean img)
        {
            _control.Image = Utilities.YesNoTypeConvert<YesNoType>(img);
            return this;
        }
        public ControlFluent Multiline(Boolean multiline)
        {
            _control.Multiline = Utilities.YesNoTypeConvert<YesNoType>(multiline);
            return this;
        }
        public ControlFluent Password(Boolean password)
        {
            _control.Password = Utilities.YesNoTypeConvert<YesNoType>(password);
            return this;
        }
        public ControlFluent Property(String prop)
        {
            _control.Property = prop;
            return this;
        }
        public ControlFluent Text(String text)
        {
            _control.Text = text;
            return this;
        }
        public ControlFluent ToolTip(String toolTip)
        {
            _control.ToolTip = toolTip;
            return this;
        }
        public ControlFluent Type(String type)
        {
            _control.Type = type;
            return this;
        }
        public ControlFluent Width(Int32 width)
        {
            _control.Width = width.ToString();
            return this;
        }
        public ControlFluent X(Int32 x)
        {
            _control.X = x.ToString();
            return this;
        }
        public ControlFluent Y(Int32 y)
        {
            _control.Y = y.ToString();
            return this;
        }
        public ControlFluent Rect(Int32 X, Int32 Y, Int32 Width, Int32 Height)
        {
            _control.X = X.ToString();
            _control.Y = Y.ToString();
            _control.Width = Width.ToString();
            _control.Height = Height.ToString();
            return this;
        }
    }
}
