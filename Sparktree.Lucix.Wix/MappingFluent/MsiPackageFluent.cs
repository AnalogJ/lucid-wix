using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using MsiPackage = Sparktree.Lucid.Wix.MappingModel.MsiPackage;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class MsiPackageFluent : BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private MsiPackage _msi;

        public MsiPackageFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement msi)
            : base(msi)
        {
            _msi = msi as MsiPackage;
        }
        public MsiPackageFluent After(String field)
        {
            _msi.After = field;
            return this;
        }
        public MsiPackageFluent Cache(Boolean field)
        {
            _msi.Cache = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MsiPackageFluent CacheId(String field)
        {
            _msi.CacheId = field;
            return this;
        }
        public MsiPackageFluent Compressed(Boolean field)
        {
            _msi.Compressed = Utilities.YesNoDefaultTypeConvert<YesNoDefaultType>(field);
            return this;
        }
        public MsiPackageFluent Description(String field)
        {
            _msi.Description = field;
            return this;
        }
        public MsiPackageFluent DisplayInternalUI(Boolean field)
        {
            _msi.DisplayInternalUI = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MsiPackageFluent DisplayName(String field)
        {
            _msi.DisplayName = field;
            return this;
        }
        public MsiPackageFluent DownloadUrl(String field)
        {
            _msi.DownloadUrl = field;
            return this;
        }
        public MsiPackageFluent EnableFeatureSelection(Boolean field)
        {
            _msi.EnableFeatureSelection = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MsiPackageFluent ForcePerMachine(Boolean field)
        {
            _msi.ForcePerMachine = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MsiPackageFluent Id(String field)
        {
            _msi.Id = field;
            return this;
        }
        public MsiPackageFluent InstallCondition(String field)
        {
            _msi.InstallCondition = field;
            return this;
        }
        public MsiPackageFluent InstallSize(String field)
        {
            _msi.InstallSize = field;
            return this;
        }
        public MsiPackageFluent LogPathVariable(String field)
        {
            _msi.LogPathVariable = field;
            return this;
        }
        public MsiPackageFluent Name(String field)
        {
            _msi.Name = field;
            return this;
        }
        public MsiPackageFluent Permanent(Boolean field)
        {
            _msi.Permanent = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MsiPackageFluent RollbackLogPathVariable(String field)
        {
            _msi.RollbackLogPathVariable = field;
            return this;
        }
        public MsiPackageFluent SourceFile(String field)
        {
            _msi.SourceFile = field;
            return this;
        }
        public MsiPackageFluent SuppressLooseFilePayloadGeneration(Boolean field)
        {
            _msi.SuppressLooseFilePayloadGeneration = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MsiPackageFluent SuppressSignatureVerification(Boolean field)
        {
            _msi.SuppressSignatureVerification = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MsiPackageFluent Visible(Boolean field)
        {
            _msi.Visible = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MsiPackageFluent Vital(Boolean field)
        {
            _msi.Vital = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
    }
}
