using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.Extensions.Bal.MappingModel;
using Sparktree.Lucid.Wix.MappingFluent;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;

namespace Sparktree.Lucid.Wix.Extensions.Bal.MappingFluent
{
    public class ConditionFluent : BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Condition _cond;

        public ConditionFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement cond)
            : base(cond)
        {
            _cond = cond as Condition;
        }

        public ConditionFluent Content(String field)
        {
            _cond.Content = field;
            return this;
        }
        public ConditionFluent Message(String field)
        {
            _cond.Message = field;
            return this;
        }
    }
}
