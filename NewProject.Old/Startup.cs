using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewProject.Web.Startup))]
namespace NewProject.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
