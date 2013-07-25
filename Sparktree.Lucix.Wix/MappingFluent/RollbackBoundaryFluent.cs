using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;
using Microsoft.Tools.WindowsInstallerXml.Serialize;

namespace Sparktree.Lucid.Wix.MappingFluent
{
    public class RollbackBoundaryFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseCreateChildrenFluent, IBaseParentElementFluent, IBaseSetAttributesFluent
    {
        private MappingModel.RollbackBoundary _roll;

        public RollbackBoundaryFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement roll)
            : base(roll)
        {
            _roll = roll as MappingModel.RollbackBoundary;
        }
        public RollbackBoundaryFluent Id(String field)
        {
            _roll.Id = field;
            return this;
        }
        public RollbackBoundaryFluent Vital(Boolean field)
        {
            _roll.Vital = Utilities.YesNoTypeConvert<YesNoType>(field);
            return this;
        }

    }
}
