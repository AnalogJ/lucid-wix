using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Configuration = Sparktree.Lucid.Wix.MappingModel.Configuration;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ConfigurationFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private Configuration _config;

        public ConfigurationFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement config)
            : base(config)
        {
            _config = config as Configuration;
        }
        public ConfigurationFluent ContextData(String contextData)
        {
            _config.ContextData = contextData;
            return this;
        }
        public ConfigurationFluent DefaultValue(String defaultVal)
        {
            _config.DefaultValue = defaultVal;
            return this;
        }
        public ConfigurationFluent Description(String descr)
        {
            _config.Description = descr;
            return this;
        }
        public ConfigurationFluent DisplayName(String disp)
        {
            _config.DisplayName = disp;
            return this;
        }
        public ConfigurationFluent Format(Microsoft.Tools.WindowsInstallerXml.Serialize.Configuration.FormatType format)
        {
            _config.Format = format;
            return this;
        }
        public ConfigurationFluent HelpKeyword(String helpKey)
        {
            _config.HelpKeyword = helpKey;
            return this;
        }
        public ConfigurationFluent HelpLocation(String helpLoc)
        {
            _config.HelpLocation = helpLoc;
            return this;
        }
        public ConfigurationFluent KeyNoOrphan(Boolean keyNoOrphan)
        {
            _config.KeyNoOrphan = Utilities.YesNoTypeConvert<YesNoType>(keyNoOrphan);
            return this;
        }
        public ConfigurationFluent Name(String name)
        {
            _config.Name = name;
            return this;
        }
        public ConfigurationFluent NonNullable(Boolean nonNull)
        {
            _config.NonNullable = Utilities.YesNoTypeConvert<YesNoType>(nonNull);
            return this;
        }
        public ConfigurationFluent Type(String type)
        {
            _config.Type = type;
            return this;
        }
    }
}
