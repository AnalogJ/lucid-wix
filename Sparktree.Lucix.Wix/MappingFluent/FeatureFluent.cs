using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Feature = Sparktree.Lucid.Wix.MappingModel.Feature;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class FeatureFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Feature _feature;

        public FeatureFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement feat)
            : base(feat)
        {
            _feature = feat as Feature;
        }
        public FeatureFluent Absent(Microsoft.Tools.WindowsInstallerXml.Serialize.Feature.AbsentType absent)
        {
            _feature.Absent = absent;
            return this;
        }
        public FeatureFluent AllowAdvertise(Microsoft.Tools.WindowsInstallerXml.Serialize.Feature.AllowAdvertiseType allowAdvertise)
        {
            _feature.AllowAdvertise = allowAdvertise;
            return this;
        }
        public FeatureFluent ConfigurableDirectory(String configDirectory)
        {
            _feature.ConfigurableDirectory = configDirectory;
            return this;
        }
        public FeatureFluent Description(String descr)
        {
            _feature.Description = descr;
            return this;
        }
        public FeatureFluent Display(String disp)
        {
            _feature.Display = disp;
            return this;
        }
        public FeatureFluent Id(String id)
        {
            _feature.Id = id;
            return this;
        }
        public FeatureFluent InstallDefault(Microsoft.Tools.WindowsInstallerXml.Serialize.Feature.InstallDefaultType installDefault)
        {
            _feature.InstallDefault = installDefault;
            return this;
        }
        public FeatureFluent Level(Int32 level)
        {
            _feature.Level = level;
            return this;
        }

        public FeatureFluent Title(String title)
        {
            _feature.Title = title;
            return this;
        }
        public FeatureFluent TypicalDefault(Microsoft.Tools.WindowsInstallerXml.Serialize.Feature.TypicalDefaultType typDefault)
        {
            _feature.TypicalDefault = typDefault;
            return this;
        }
        
    }
}
