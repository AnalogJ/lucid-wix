using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using MajorUpgrade = Sparktree.Lucid.Wix.MappingModel.MajorUpgrade;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class MajorUpgradeFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private MajorUpgrade _majorUpgrade;

        public MajorUpgradeFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement majorUpgrade)
            : base(majorUpgrade)
        {
            _majorUpgrade = majorUpgrade as MajorUpgrade;
        }
        public MajorUpgradeFluent AllowDowngrades(Boolean field)
        {
            _majorUpgrade.AllowDowngrades = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MajorUpgradeFluent AllowSameVersionUpgrades(Boolean field)
        {
            _majorUpgrade.AllowSameVersionUpgrades = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MajorUpgradeFluent Disallow(Boolean field)
        {
            _majorUpgrade.Disallow = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MajorUpgradeFluent DisallowUpgradeErrorMessage(String field)
        {
            _majorUpgrade.DisallowUpgradeErrorMessage = field;
            return this;
        }
        public MajorUpgradeFluent DowngradeErrorMessage(String field)
        {
            _majorUpgrade.DowngradeErrorMessage = field;
            return this;
        }
        public MajorUpgradeFluent IgnoreRemoveFailure(Boolean field)
        {
            _majorUpgrade.IgnoreRemoveFailure = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MajorUpgradeFluent MigrateFeatures(Boolean field)
        {
            _majorUpgrade.MigrateFeatures = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public MajorUpgradeFluent RemoveFeatures(String field)
        {
            _majorUpgrade.RemoveFeatures = field;
            return this;
        }
        public MajorUpgradeFluent Schedule(Microsoft.Tools.WindowsInstallerXml.Serialize.MajorUpgrade.ScheduleType field)
        {
            _majorUpgrade.Schedule = field;
            return this;
        }
    }
}
