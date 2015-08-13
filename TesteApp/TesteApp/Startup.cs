using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteApp.Startup))]
namespace TesteApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
