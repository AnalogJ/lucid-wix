using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Dialog = Sparktree.Lucid.Wix.MappingModel.Dialog;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class DialogFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Dialog _dialog;

        public DialogFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement dialog)
            : base(dialog)
        {
            _dialog = dialog as Dialog;
        }
        public DialogFluent RequiredVersion(Boolean customPalette)
        {
            _dialog.CustomPalette = Utilities.YesNoTypeConvert<YesNoType>(customPalette);
            return this;
        }
        public DialogFluent ErrorDialog(Boolean err)
        {
            _dialog.ErrorDialog = Utilities.YesNoTypeConvert<YesNoType>(err);
            return this;
        }
        public DialogFluent Height(Int32 height)
        {
            _dialog.Height = height;
            return this;
        }
        public DialogFluent Hidden(Boolean hid)
        {
            _dialog.Hidden = Utilities.YesNoTypeConvert<YesNoType>(hid);
            return this;
        }
        public DialogFluent Id(String id)
        {
            _dialog.Id = id;
            return this;
        }
        public DialogFluent Title(String title)
        {
            _dialog.Title = title;
            return this;
        }
        public DialogFluent Width(Int32 width)
        {
            _dialog.Width = width;
            return this;
        }
        public DialogFluent X(Int32 x)
        {
            _dialog.X = x;
            return this;
        }
        public DialogFluent Y(Int32 y)
        {
            _dialog.Y = y;
            return this;
        }
    }
}
