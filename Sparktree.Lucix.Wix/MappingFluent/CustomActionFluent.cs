using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using CustomAction = Sparktree.Lucid.Wix.MappingModel.CustomAction;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class CustomActionFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private CustomAction _customAction;

        public CustomActionFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement customAction)
            : base(customAction)
        {
            _customAction = customAction as CustomAction;
        }
        public CustomActionFluent BinaryKey(String binaryKey)
        {
            _customAction.BinaryKey = binaryKey;
            return this;
        }
        public CustomActionFluent Content(String cont)
        {
            _customAction.Content = cont;
            return this;
        }
        public CustomActionFluent Directory(String dir)
        {
            _customAction.Directory = dir;
            return this;
        }
        public CustomActionFluent DllEntry(String dll)
        {
            _customAction.DllEntry = dll;
            return this;
        }
        public CustomActionFluent Error(String err)
        {
            _customAction.Error = err;
            return this;
        }
        public CustomActionFluent ExeCommand(String exeCmd)
        {
            _customAction.ExeCommand = exeCmd;
            return this;
        }
        public CustomActionFluent Execute(Microsoft.Tools.WindowsInstallerXml.Serialize.CustomAction.ExecuteType execute)
        {
            _customAction.Execute = execute;
            return this;
        }
        public CustomActionFluent FileKey(String fileKey)
        {
            _customAction.FileKey = fileKey;
            return this;
        }
        public CustomActionFluent HideTarget(Boolean hideTarget)
        {
            _customAction.HideTarget = Utilities.YesNoTypeConvert<YesNoType>(hideTarget);
            return this;
        }
        public CustomActionFluent Id(String id)
        {
            _customAction.Id = id;
            return this;
        }
        public CustomActionFluent IdByName(String id)
        {
            _customAction.Id = Utilities.GenerateCustomActionId(id);
            return this;
        }

        public CustomActionFluent Impersonate(Boolean imp)
        {
            _customAction.Impersonate = Utilities.YesNoTypeConvert<YesNoType>(imp);
            return this;
        }
        public CustomActionFluent JScriptCall(String jScriptCall)
        {
            _customAction.JScriptCall = jScriptCall;
            return this;
        }
        public CustomActionFluent PatchUninstall(Boolean patchUninstall)
        {
            _customAction.PatchUninstall = Utilities.YesNoTypeConvert<YesNoType>(patchUninstall);
            return this;
        }
        public CustomActionFluent Property(String prop)
        {
            _customAction.Property = prop;
            return this;
        }
        public CustomActionFluent Return(Microsoft.Tools.WindowsInstallerXml.Serialize.CustomAction.ReturnType ret)
        {
            _customAction.Return = ret;
            return this;
        }
        public CustomActionFluent Script(Microsoft.Tools.WindowsInstallerXml.Serialize.CustomAction.ScriptType script)
        {
            _customAction.Script = script;
            return this;
        }
        public CustomActionFluent SuppressModularization(Boolean sup)
        {
            _customAction.SuppressModularization = Utilities.YesNoTypeConvert<YesNoType>(sup);
            return this;
        }
        public CustomActionFluent TerminalServerAware(Boolean term)
        {
            _customAction.TerminalServerAware = Utilities.YesNoTypeConvert<YesNoType>(term);
            return this;
        }
        public CustomActionFluent Value(String val)
        {
            _customAction.Value = val;
            return this;
        }
        public CustomActionFluent VBScriptCall(String vbScriptCall)
        {
            _customAction.VBScriptCall = vbScriptCall;
            return this;
        }
        public CustomActionFluent Win64(Boolean win64)
        {
            _customAction.Win64 = Utilities.YesNoTypeConvert<YesNoType>(win64);
            return this;
        }
    }
}
