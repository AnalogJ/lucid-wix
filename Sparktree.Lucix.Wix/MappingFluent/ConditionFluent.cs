using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Condition = Sparktree.Lucid.Wix.MappingModel.Condition;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ConditionFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private Condition _cond;

        public ConditionFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement cond)
            : base(cond)
        {
            _cond = cond as Condition;
        }
        public ConditionFluent Action(Microsoft.Tools.WindowsInstallerXml.Serialize.Condition.ActionType actionType)
        {
            _cond.Action = actionType;
            return this;
        }
        public ConditionFluent Content(String content)
        {
            _cond.Content = content;
            return this;
        }
        public ConditionFluent Level(Int32 level)
        {
            _cond.Level = level;
            return this;
        }
        public ConditionFluent Message(String message)
        {
            _cond.Message = message;
            return this;
        }
    }
}
