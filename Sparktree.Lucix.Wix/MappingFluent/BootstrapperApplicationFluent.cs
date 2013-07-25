using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class BootstrapperApplicationFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private readonly BootstrapperApplication _bootstrapper;

        public BootstrapperApplicationFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement bootstrapper)
            : base(bootstrapper)
        {
            _bootstrapper = bootstrapper as BootstrapperApplication;
        }
        public BootstrapperApplicationFluent Id(String id)
        {
            _bootstrapper.Id = id;
            return this;
        }
        public BootstrapperApplicationFluent Name(String name)
        {
            _bootstrapper.Name = name;
            return this;
        }

        public BootstrapperApplicationFluent SourceFile(String sourceFile)
        {
            _bootstrapper.SourceFile = sourceFile;
            return this;
        }
    }
}
