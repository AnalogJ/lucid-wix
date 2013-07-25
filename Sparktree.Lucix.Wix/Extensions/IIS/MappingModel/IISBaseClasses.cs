using Sparktree.Lucid.Wix.Extensions.IIS.MappingFluent;

namespace Sparktree.Lucid.Wix.Extensions.IIS.MappingModel
{
    public class RecycleTime : Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.IIs.RecycleTime
    {

        private RecycleTimeFluent _set;
        public RecycleTime()
        {
            _set = new RecycleTimeFluent(this);
        }
        public RecycleTimeFluent Set
        {
            get { return _set; }
        }

    }

    public class WebAddress : Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.IIs.WebAddress
    {

        private WebAddressFluent _set;
        public WebAddress()
        {
            _set = new WebAddressFluent(this);
        }
        public WebAddressFluent Set
        {
            get { return _set; }
        }

    }

    public class WebApplication : Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.IIs.WebApplication
    {

        private WebApplicationFluent _set;
        public WebApplication()
        {
            _set = new WebApplicationFluent(this);
        }
        public WebApplicationFluent Set
        {
            get { return _set; }
        }

    }



    public class WebAppPool : Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.IIs.WebAppPool
    {

        private WebAppPoolFluent _set;
        public WebAppPool()
        {
            _set = new WebAppPoolFluent(this);
        }
        public WebAppPoolFluent Set
        {
            get { return _set; }
        }

    }

    public class WebSite : Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.IIs.WebSite
    {

        private WebSiteFluent _set;
        public WebSite()
        {
            _set = new WebSiteFluent(this);
        }
        public WebSiteFluent Set
        {
            get { return _set; }
        }

    }

    public class WebVirtualDir : Microsoft.Tools.WindowsInstallerXml.Extensions.Serialize.IIs.WebVirtualDir
    {

        private WebVirtualDirFluent _set;
        public WebVirtualDir()
        {
            _set = new WebVirtualDirFluent(this);
        }
        public WebVirtualDirFluent Set
        {
            get { return _set; }
        }

    }

}
