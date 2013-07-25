using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class FragmentFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private Fragment _fragment;

        public FragmentFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement fragment)
            : base(fragment)
        {
            _fragment = fragment as Fragment;
        }
        public FragmentFluent Id(String id)
        {
            _fragment.Id = id;
            return this;
        }

    }
}
