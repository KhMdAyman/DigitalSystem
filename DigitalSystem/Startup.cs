using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigitalSystem.Startup))]
namespace DigitalSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
