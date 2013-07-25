using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    
    public class WixFluent : BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private MappingModel.Wix _wix;

        public WixFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement wix)
            : base(wix)
        {
            _wix = wix as MappingModel.Wix;
        }
        public WixFluent RequiredVersion(String field)
        {
            _wix.RequiredVersion = field;
            return this;
        }

    }
}
