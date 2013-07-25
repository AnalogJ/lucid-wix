using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Custom = Sparktree.Lucid.Wix.MappingModel.Custom;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class CustomFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private Custom _custom;

        public CustomFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement custom)
            : base(custom)
        {
            _custom = custom as Custom;
        }
        public CustomFluent Action(String action)
        {
            _custom.Action = action;
            return this;
        }
        public CustomFluent After(String after)
        {
            _custom.After = after;
            return this;
        }
        public CustomFluent Before(String before)
        {
            _custom.Before = before;
            return this;
        }
        public CustomFluent Content(String content)
        {
            _custom.Content = content;
            return this;
        }
        public CustomFluent OnExit(ExitType exit)
        {
            _custom.OnExit = exit;
            return this;
        }
        public CustomFluent Overridable(Boolean overridable)
        {
            _custom.Overridable = Utilities.YesNoTypeConvert<YesNoType>(overridable);
            return this;
        }
        public CustomFluent Sequence(Int32 sequence)
        {
            _custom.Sequence = sequence;
            return this;
        }
    }
}
