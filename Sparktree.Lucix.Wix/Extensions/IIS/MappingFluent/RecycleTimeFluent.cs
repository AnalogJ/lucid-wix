using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.MappingFluent;
using Sparktree.Lucid.Wix.MappingFluent.Abstract;

namespace Sparktree.Lucid.Wix.Extensions.IIS.MappingFluent
{
    public class RecycleTimeFluent: BaseSchemaFluent, IBaseSchemaFluent, IBaseSetAttributesFluent
    {
        private Extensions.IIS.MappingModel.RecycleTime _recTime;

        public RecycleTimeFluent(Microsoft.Tools.WindowsInstallerXml.Serialize.ISchemaElement recTime)
            : base(recTime)
        {
            _recTime = recTime as Extensions.IIS.MappingModel.RecycleTime;
        }
        public RecycleTimeFluent Value(String field)
        {
            _recTime.Value = field;
            return this;
        }
    }
}
