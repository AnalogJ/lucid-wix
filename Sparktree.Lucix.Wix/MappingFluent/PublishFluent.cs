using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class PublishFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private Publish _pub;

        public PublishFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement pub)
            : base(pub)
        {
            _pub = pub as Publish;
        }
        public PublishFluent Content(String field)
        {
            _pub.Content = field;
            return this;
        }
        public PublishFluent Control(String field)
        {
            _pub.Control = field;
            return this;
        }
        public PublishFluent Dialog(String field)
        {
            _pub.Dialog = field;
            return this;
        }
        public PublishFluent Event(String field)
        {
            _pub.Event = field;
            return this;
        }
        public PublishFluent Order(String field)
        {
            _pub.Order = field;
            return this;
        }
        public PublishFluent Property(String field)
        {
            _pub.Property = field;
            return this;
        }
        public PublishFluent Value(String field)
        {
            _pub.Value = field;
            return this;
        }

    }
}
