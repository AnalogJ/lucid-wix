using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.Extensions.Bal.MappingFluent;

namespace Sparktree.Lucid.Wix.Extensions.Bal.MappingModel
{
    public class Condition : Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.Bal.Condition
    {

        private ConditionFluent _set;
        public Condition()
        {
            _set = new ConditionFluent(this);
        }
        public ConditionFluent Set
        {
            get { return _set; }
        }

    }

    public class WixStandardBootstrapperApplication : Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.Bal.WixStandardBootstrapperApplication
    {

        private WixStandardBootstrapperApplicationFluent _set;
        public WixStandardBootstrapperApplication()
        {
            _set = new WixStandardBootstrapperApplicationFluent(this);
        }
        public WixStandardBootstrapperApplicationFluent Set
        {
            get { return _set; }
        }

    }

}
