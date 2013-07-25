using System;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Sparktree.Lucid.Wix.MappingModel;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class CustomActionRefFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private CustomActionRef _caref;

        public CustomActionRefFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement caref)
            : base(caref)
        {
            _caref = caref as CustomActionRef;
        }
        public CustomActionRefFluent Id(String id)
        {
            _caref.Id = id;
            return this;
        }

    }
}
