using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Bundle = Sparktree.Lucid.Wix.MappingModel.Bundle;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class BundleFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Bundle _bundle;

        public BundleFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement bundle)
            : base(bundle)
        {
            _bundle = bundle as Bundle;
        }
        public BundleFluent AboutUrl(String aboutUrl)
        {
            _bundle.AboutUrl = aboutUrl;
            return this;
        }
        public BundleFluent Compressed(YesNoDefaultType compressed)
        {
            _bundle.Compressed = compressed;
            return this;
        }
        public BundleFluent Condition(String condition)
        {
            _bundle.Condition = condition;
            return this;
        }
        public BundleFluent Copyright(String copyright)
        {
            _bundle.Copyright = copyright;
            return this;
        }
        public BundleFluent DisableModify(YesNoButtonType disableModify)
        {
            _bundle.DisableModify = disableModify;
            return this;
        }
        public BundleFluent DisableRemove(Boolean disableRemove)
        {
            _bundle.DisableRemove = Utilities.YesNoTypeConvert<YesNoType>(disableRemove);
            return this;
        }
        public BundleFluent DisableRepair(Boolean disableRepair)
        {
            _bundle.DisableRepair = Utilities.YesNoTypeConvert<YesNoType>(disableRepair);
            return this;
        }
        public BundleFluent HelpTelephone(String helpTelephone)
        {
            _bundle.HelpTelephone = helpTelephone;
            return this;
        }
        public BundleFluent HelpUrl(String helpUrl)
        {
            _bundle.HelpUrl = helpUrl;
            return this;
        }
        public BundleFluent IconSourceFile(String iconSource)
        {
            _bundle.IconSourceFile = iconSource;
            return this;
        }
        public BundleFluent Manufacturer(String manu)
        {
            _bundle.Manufacturer = manu;
            return this;
        }
        public BundleFluent Name(String name)
        {
            _bundle.Name = name;
            return this;
        }
        public BundleFluent ParentName(String name)
        {
            _bundle.ParentName = name;
            return this;
        }
        public BundleFluent SplashScreenSourceFile(String sourceFile)
        {
            _bundle.SplashScreenSourceFile = sourceFile;
            return this;
        }
        public BundleFluent Tag(String tag)
        {
            _bundle.Tag = tag;
            return this;
        }
        public BundleFluent UpdateUrl(String updateUrl)
        {
            _bundle.UpdateUrl = updateUrl;
            return this;
        }
        public BundleFluent UpgradeCode(String upgradeCode)
        {
            _bundle.UpgradeCode = upgradeCode;
            return this;
        }
        public BundleFluent Version(String version)
        {
            _bundle.Version = version;
            return this;
        }

    }
}
