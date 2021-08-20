using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SACLA.Startup))]
namespace SACLA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
