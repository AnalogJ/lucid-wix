using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.IIs;

namespace Sparktree.Lucid.Wix.Extensions.IIS.MappingFluent
{
    public class WebApplicationFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Extensions.IIS.MappingModel.WebApplication _webApp;

        public WebApplicationFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement webApp)
            : base(webApp)
        {
            _webApp = webApp as Extensions.IIS.MappingModel.WebApplication;
        }
        public WebApplicationFluent AllowSessions(YesNoDefaultType field)
        {
            _webApp.AllowSessions = field;
            return this;
        }
        public WebApplicationFluent Buffer(YesNoDefaultType field)
        {
            _webApp.Buffer = field;
            return this;
        }
        public WebApplicationFluent ClientDebugging(YesNoDefaultType field)
        {
            _webApp.ClientDebugging = field;
            return this;
        }
        public WebApplicationFluent DefaultScript(WebApplication.DefaultScriptType field)
        {
            _webApp.DefaultScript = field;
            return this;
        }
        public WebApplicationFluent Id(String field)
        {
            _webApp.Id = field;
            return this;
        }
        public WebApplicationFluent Isolation(WebApplication.IsolationType field)
        {
            _webApp.Isolation = field;
            return this;
        }
        public WebApplicationFluent Name(String field)
        {
            _webApp.Name = field;
            return this;
        }
        public WebApplicationFluent ParentPaths(YesNoDefaultType field)
        {
            _webApp.ParentPaths = field;
            return this;
        }
        public WebApplicationFluent ScriptTimeout(Int32 field)
        {
            _webApp.ScriptTimeout = field;
            return this;
        }
        public WebApplicationFluent ServerDebugging(YesNoDefaultType field)
        {
            _webApp.ServerDebugging = field;
            return this;
        }
        public WebApplicationFluent SessionTimeout(Int32 field)
        {
            _webApp.SessionTimeout = field;
            return this;
        }
        public WebApplicationFluent WebAppPool(String field)
        {
            _webApp.WebAppPool = field;
            return this;
        }
    }
}
