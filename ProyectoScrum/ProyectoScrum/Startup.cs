using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoScrum.Startup))]
namespace ProyectoScrum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
