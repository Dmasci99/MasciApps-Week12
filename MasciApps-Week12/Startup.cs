using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasciApps_Week12.Startup))]
namespace MasciApps_Week12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
