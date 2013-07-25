using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;
using Payload = Sparktree.Lucid.Wix.MappingModel.Payload;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class PayloadFluent: BaseSchemaFluent, IBaseSchemaFluent,  IBaseSetAttributesFluent
    {
        private Payload _payload;

        public PayloadFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement payload)
            : base(payload)
        {
            _payload = payload as Payload;
        }
        public PayloadFluent Compressed(Boolean field)
        {
            _payload.Compressed = Utilities.YesNoDefaultTypeConvert<YesNoDefaultType>(field);
            return this;
        }
        public PayloadFluent DownloadUrl(String field)
        {
            _payload.DownloadUrl = field;
            return this;
        }
        public PayloadFluent Id(String field)
        {
            _payload.Id = field;
            return this;
        }
        public PayloadFluent Name(String field)
        {
            _payload.Name = field;
            return this;
        }
        public PayloadFluent SourceFile(String field)
        {
            _payload.SourceFile = field;
            return this;
        }
        public PayloadFluent SuppressSignatureVerification(Boolean field)
        {
            _payload.SuppressSignatureVerification = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }

    }
}
