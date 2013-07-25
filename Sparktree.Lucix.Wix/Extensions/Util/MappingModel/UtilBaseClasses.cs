using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sparktree.Lucid.Wix.Extensions.Util.MappingFluent;

namespace Sparktree.Lucid.Wix.Extensions.Util.MappingModel
{
    public class RegistySearch : Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.Util.RegistrySearch
    {

        private RegistySearchFluent _set;
        public RegistySearch()
        {
            _set = new RegistySearchFluent(this);
        }
        public RegistySearchFluent Set
        {
            get { return _set; }
        }

    }
}
