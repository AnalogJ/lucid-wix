using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;

namespace Sparktree.Lucid.Wix.Extensions.IIS.MappingFluent
{
    public class WebVirtualDirFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private Extensions.IIS.MappingModel.WebVirtualDir _virDir;

        public WebVirtualDirFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement virDir)
            : base(virDir)
        {
            _virDir = virDir as Extensions.IIS.MappingModel.WebVirtualDir;
        }
        public WebVirtualDirFluent Alias(String field)
        {
            _virDir.Alias = field;
            return this;
        }
        public WebVirtualDirFluent Directory(String field)
        {
            _virDir.Directory = field;
            return this;
        }
        public WebVirtualDirFluent DirProperties(String field)
        {
            _virDir.DirProperties = field;
            return this;
        }
        public WebVirtualDirFluent Id(String field)
        {
            _virDir.Id = field;
            return this;
        }
        public WebVirtualDirFluent WebApplication(String field)
        {
            _virDir.WebApplication = field;
            return this;
        }
        public WebVirtualDirFluent WebSite(String field)
        {
            _virDir.WebSite = field;
            return this;
        }
    }
}
