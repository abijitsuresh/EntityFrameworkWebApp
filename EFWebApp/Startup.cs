using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFWebApp.Startup))]
namespace EFWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
