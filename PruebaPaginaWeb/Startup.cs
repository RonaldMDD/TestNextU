using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaPaginaWeb.Startup))]
namespace PruebaPaginaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
