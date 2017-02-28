using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GurpoII.Startup))]
namespace GurpoII
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
