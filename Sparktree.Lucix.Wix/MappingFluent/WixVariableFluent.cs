using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class WixVariableFluent: BaseSchemaFluent, IBaseSchemaFluent,  IBaseSetAttributesFluent
    {
        private MappingModel.WixVariable _wixvar;

        public WixVariableFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement wixvar)
            : base(wixvar)
        {
            _wixvar = wixvar as MappingModel.WixVariable;
        }
        public WixVariableFluent Id(String field)
        {
            _wixvar.Id = field;
            return this;
        }
        public WixVariableFluent Overridable(Boolean field)
        {
            _wixvar.Overridable = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public WixVariableFluent Value(String field)
        {
            _wixvar.Value = field;
            return this;
        }
    }
}
