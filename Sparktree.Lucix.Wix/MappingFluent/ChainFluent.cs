using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Chain = Sparktree.Lucid.Wix.MappingModel.Chain;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ChainFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Chain _chain;

        public ChainFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement chain)
            : base(chain)
        {
            _chain = chain as Chain;
        }
        public ChainFluent DisableRollback(Boolean disable)
        {
            _chain.DisableRollback = Utilities.YesNoTypeConvert<YesNoType>(disable);
            return this;
        }
        public ChainFluent DisableSystemRestore(Boolean disable)
        {
            _chain.DisableSystemRestore = Utilities.YesNoTypeConvert<YesNoType>(disable);
            return this;
        }
        public ChainFluent ParallelCache(Boolean cache)
        {
            _chain.ParallelCache = Utilities.YesNoTypeConvert<YesNoType>(cache);
            return this;
        }
    }
}
