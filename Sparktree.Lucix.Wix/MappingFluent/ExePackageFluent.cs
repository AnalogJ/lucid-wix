using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using ExePackage = Sparktree.Lucid.Wix.MappingModel.ExePackage;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ExePackageFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private ExePackage _exePackage;

        public ExePackageFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement exePackage)
            : base(exePackage)
        {
            _exePackage = exePackage as ExePackage;
        }
        public ExePackageFluent After(String after)
        {
            _exePackage.After = after;
            return this;
        }
        public ExePackageFluent Cache(Boolean cache)
        {
            _exePackage.Cache = Utilities.YesNoTypeConvert<YesNoType>(cache);
            return this;
        }
        public ExePackageFluent CacheId(String cacheId)
        {
            _exePackage.CacheId = cacheId;
            return this;
        }
        public ExePackageFluent Compressed(Boolean? compressed)
        {
            _exePackage.Compressed = Utilities.YesNoDefaultTypeConvert<YesNoDefaultType>(compressed);
            return this;
        }
        public ExePackageFluent DetectCondition(String detect)
        {
            _exePackage.DetectCondition = detect;
            return this;
        }
        public ExePackageFluent DownloadUrl(String dlUrl)
        {
            _exePackage.DownloadUrl = dlUrl;
            return this;
        }
        public ExePackageFluent Id(String id)
        {
            _exePackage.Id = id;
            return this;
        }
        public ExePackageFluent InstallCommand(String install)
        {
            _exePackage.InstallCommand = install;
            return this;
        }
        public ExePackageFluent InstallCondition(String condition)
        {
            _exePackage.InstallCondition = condition;
            return this;
        }
        public ExePackageFluent InstallSize(String installSize)
        {
            _exePackage.InstallSize = installSize;
            return this;
        }
        public ExePackageFluent LogPathVariable(String logPathVariable)
        {
            _exePackage.LogPathVariable = logPathVariable;
            return this;
        }
        public ExePackageFluent Name(String name)
        {
            _exePackage.Name = name;
            return this;
        }
        public ExePackageFluent PerMachine(Boolean? perMachine)
        {
            _exePackage.PerMachine = Utilities.YesNoDefaultTypeConvert<YesNoDefaultType>(perMachine);
            return this;
        }
        public ExePackageFluent Permanent(Boolean permanent)
        {
            _exePackage.Permanent = Utilities.YesNoTypeConvert<YesNoType>(permanent); ;
            return this;
        }
        public ExePackageFluent Protocol(BurnExeProtocolType protocol)
        {
            _exePackage.Protocol = protocol;
            return this;
        }
        public ExePackageFluent RepairCommand(String repairCmd)
        {
            _exePackage.RepairCommand = repairCmd;
            return this;
        }
        public ExePackageFluent RollBackLogPathVariab(String rollback)
        {
            _exePackage.RollbackLogPathVariable = rollback;
            return this;
        }
        public ExePackageFluent SourceFile(String sourceFile)
        {
            _exePackage.SourceFile = sourceFile;
            return this;
        }
        public ExePackageFluent SuppressSignatureVerification(Boolean suppress)
        {
            _exePackage.SuppressSignatureVerification = Utilities.YesNoTypeConvert<YesNoType>(suppress); ;
            return this;
        }
        public ExePackageFluent UninstallCommand(String uninstall)
        {
            _exePackage.UninstallCommand = uninstall;
            return this;
        }
        public ExePackageFluent Vital(Boolean vital)
        {
            _exePackage.Vital = Utilities.YesNoTypeConvert<YesNoType>(vital); ;
            return this;
        }
    }
}
