using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FastTracker.Web.Startup))]
namespace FastTracker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
