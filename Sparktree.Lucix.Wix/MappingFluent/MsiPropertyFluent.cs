using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class MsiPropertyFluent : BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private MsiProperty _msi;

        public MsiPropertyFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement msi)
            : base(msi)
        {
            _msi = msi as MsiProperty;
        }
        public MsiPropertyFluent Name(String field)
        {
            _msi.Name = field;
            return this;
        }
        public MsiPropertyFluent Value(String field)
        {
            _msi.Value = field;
            return this;
        }
    }
}
