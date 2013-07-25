using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class UIFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private MappingModel.UI _ui;

        public UIFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement ui)
            : base(ui)
        {
            _ui = ui as MappingModel.UI;
        }
        public UIFluent Id(String field)
        {
            _ui.Id = field;
            return this;
        }

    }
}
