using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.IIs;

namespace Sparktree.Lucid.Wix.Extensions.IIS.MappingFluent
{
    public class WebAppPoolFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Extensions.IIS.MappingModel.WebAppPool _webApp;

        public WebAppPoolFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement webApp)
            : base(webApp)
        {
            _webApp = webApp as Extensions.IIS.MappingModel.WebAppPool;
        }
        public WebAppPoolFluent CpuAction(WebAppPool.CpuActionType field)
        {
            _webApp.CpuAction = field;
            return this;
        }
        public WebAppPoolFluent Id(String field)
        {
            _webApp.Id = field;
            return this;
        }
        public WebAppPoolFluent Identity(WebAppPool.IdentityType field)
        {
            _webApp.Identity = field;
            return this;
        }
        public WebAppPoolFluent IdleTimeout(Int32 field)
        {
            _webApp.IdleTimeout = field;
            return this;
        }
        public WebAppPoolFluent ManagedPipelineMode(String field)
        {
            _webApp.ManagedPipelineMode = field;
            return this;
        }
        public WebAppPoolFluent ManagedRuntimeVersion(String field)
        {
            _webApp.ManagedRuntimeVersion = field;
            return this;
        }
        public WebAppPoolFluent MaxCpuUsage(long field)
        {
            _webApp.MaxCpuUsage = field;
            return this;
        }
        public WebAppPoolFluent MaxWorkerProcesses(Int32 field)
        {
            _webApp.MaxWorkerProcesses = field;
            return this;
        }
        public WebAppPoolFluent Name(String field)
        {
            _webApp.Name = field;
            return this;
        }
        public WebAppPoolFluent PrivateMemory(Int32 field)
        {
            _webApp.PrivateMemory = field;
            return this;
        }
        public WebAppPoolFluent QueueLimit(Int32 field)
        {
            _webApp.QueueLimit = field;
            return this;
        }
        public WebAppPoolFluent RecycleMinutes(Int32 field)
        {
            _webApp.RecycleMinutes = field;
            return this;
        }
        public WebAppPoolFluent RecycleRequests(Int32 field)
        {
            _webApp.RecycleRequests = field;
            return this;
        }
        public WebAppPoolFluent RefreshCpu(Int32 field)
        {
            _webApp.RefreshCpu = field;
            return this;
        }
        public WebAppPoolFluent User(String field)
        {
            _webApp.User = field;
            return this;
        }
        public WebAppPoolFluent VirtualMemory(Int32 field)
        {
            _webApp.VirtualMemory = field;
            return this;
        }
    }
}
