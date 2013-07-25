using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.IIs;

namespace Sparktree.Lucid.Wix.Extensions.IIS.MappingFluent
{
    public class WebSiteFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Extensions.IIS.MappingModel.WebSite _webSite;

        public WebSiteFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement webSite)
            : base(webSite)
        {
            _webSite = webSite as Extensions.IIS.MappingModel.WebSite;
        }
        public WebSiteFluent AutoStart(Boolean field)
        {
            _webSite.AutoStart = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public WebSiteFluent ConfigureIfExists(Boolean field)
        {
            _webSite.ConfigureIfExists = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public WebSiteFluent ConnectionTimeout(long field)
        {
            _webSite.ConnectionTimeout = field;
            return this;
        }
        public WebSiteFluent Description(String field)
        {
            _webSite.Description = field;
            return this;
        }
        public WebSiteFluent DirProperties(String field)
        {
            _webSite.DirProperties = field;
            return this;
        }
        public WebSiteFluent Id(String field)
        {
            _webSite.Id = field;
            return this;
        }
        public WebSiteFluent Sequence(Int32 field)
        {
            _webSite.Sequence = field;
            return this;
        }
        public WebSiteFluent SiteId(String field)
        {
            _webSite.SiteId = field;
            return this;
        }
        public WebSiteFluent StartOnInstall(Boolean field)
        {
            _webSite.StartOnInstall = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
        public WebSiteFluent WebApplication(String field)
        {
            _webSite.WebApplication = field;
            return this;
        }
        public WebSiteFluent WebLog(String field)
        {
            _webSite.WebLog = field;
            return this;
        }
    }
}
