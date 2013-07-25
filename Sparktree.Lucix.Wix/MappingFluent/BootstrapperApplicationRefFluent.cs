using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class BootstrapperApplicationRefFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private BootstrapperApplicationRef _bootstrapper;

        public BootstrapperApplicationRefFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement bootstrapper)
            : base(bootstrapper)
        {
            _bootstrapper = bootstrapper as BootstrapperApplicationRef;
        }
        public BootstrapperApplicationRefFluent Id(String id)
        {
            _bootstrapper.Id = id;
            return this;
        }

    }
}
