using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Omega.Startup))]
namespace Omega
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
