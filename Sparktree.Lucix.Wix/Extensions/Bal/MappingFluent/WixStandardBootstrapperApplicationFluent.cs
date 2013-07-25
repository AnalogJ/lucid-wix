using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.Bal;
using WixStandardBootstrapperApplication = Sparktree.Lucid.Wix.Extensions.Bal.MappingModel.WixStandardBootstrapperApplication;


namespace Sparktree.Lucid.Wix.Extensions.Bal.MappingFluent
{
    public class WixStandardBootstrapperApplicationFluent : BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private WixStandardBootstrapperApplication _bootstrapper;

        public WixStandardBootstrapperApplicationFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement bootstrapper)
            : base(bootstrapper)
        {
            _bootstrapper = bootstrapper as WixStandardBootstrapperApplication;
        }

        public WixStandardBootstrapperApplicationFluent LicenseFile(String field)
        {
            _bootstrapper.LicenseFile = field;
            return this;
        }
        public WixStandardBootstrapperApplicationFluent LicenseUrl(String field)
        {
            _bootstrapper.LicenseUrl = field;
            return this;
        }
        public WixStandardBootstrapperApplicationFluent LocalizationFile(String field)
        {
            _bootstrapper.LocalizationFile = field;
            return this;
        }
        public WixStandardBootstrapperApplicationFluent LogoFIle(String field)
        {
            _bootstrapper.LogoFile = field;
            return this;
        }
        public WixStandardBootstrapperApplicationFluent SuppressDowngradeFailure(Boolean field)
        {
            _bootstrapper.SuppressDowngradeFailure = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public WixStandardBootstrapperApplicationFluent SuppressOptionsUI(Boolean field)
        {
            _bootstrapper.SuppressOptionsUI = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public WixStandardBootstrapperApplicationFluent ThemeFile(String field)
        {
            _bootstrapper.ThemeFile = field;
            return this;
        }
    }
}
