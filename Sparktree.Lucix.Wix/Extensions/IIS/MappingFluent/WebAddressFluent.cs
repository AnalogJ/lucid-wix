using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.IIs;


namespace Sparktree.Lucid.Wix.Extensions.IIS.MappingFluent
{
    public class WebAddressFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private Extensions.IIS.MappingModel.WebAddress _webAddr;

        public WebAddressFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement webAddr)
            : base(webAddr)
        {
            _webAddr = webAddr as Extensions.IIS.MappingModel.WebAddress;
        }
        public WebAddressFluent Header(String field)
        {
            _webAddr.Header = field;
            return this;
        }
        public WebAddressFluent Id(String field)
        {
            _webAddr.Id = field;
            return this;
        }
        public WebAddressFluent IP(String field)
        {
            _webAddr.IP = field;
            return this;
        }
        public WebAddressFluent Port(String field)
        {
            _webAddr.Port = field;
            return this;
        }
        public WebAddressFluent Secure(Boolean field)
        {
            _webAddr.Secure = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }
    }
}
