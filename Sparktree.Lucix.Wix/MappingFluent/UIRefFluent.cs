using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class UIRefFluent: BaseSchemaFluent, IBaseSchemaFluent,  IBaseSetAttributesFluent
    {
        private MappingModel.UIRef _uiRef;

        public UIRefFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement uiRef)
            : base(uiRef)
        {
            _uiRef = uiRef as MappingModel.UIRef;
        }
        public UIRefFluent Id(String field)
        {
            _uiRef.Id = field;
            return this;
        }

    }
}
