using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PMSystem.Startup))]
namespace PMSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
