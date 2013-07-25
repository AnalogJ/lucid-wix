using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class ComponentGroupFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private ComponentGroup _compGrp;

        public ComponentGroupFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement compGrp)
            : base(compGrp)
        {
            _compGrp = compGrp as ComponentGroup;
        }
        public ComponentGroupFluent Directory(String dir)
        {
            _compGrp.Directory = dir;
            return this;
        }
        public ComponentGroupFluent Id(String id)
        {
            _compGrp.Id = id;
            return this;
        }
        public ComponentGroupFluent Source(String source)
        {
            _compGrp.Source = source;
            return this;
        }
    }
}
