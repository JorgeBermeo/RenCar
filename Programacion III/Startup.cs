using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Programacion_III.Startup))]
namespace Programacion_III
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
