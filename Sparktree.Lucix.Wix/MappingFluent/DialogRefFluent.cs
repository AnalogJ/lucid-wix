using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class DialogRefFluent: BaseSchemaFluent, IBaseSchemaFluent,  IBaseSetAttributesFluent
    {
        private DialogRef _dialogRef;

        public DialogRefFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement dialogRef)
            : base(dialogRef)
        {
            _dialogRef = dialogRef as DialogRef;
        }
        public DialogRefFluent Id(String id)
        {
            _dialogRef.Id = id;
            return this;
        }

    }
}
