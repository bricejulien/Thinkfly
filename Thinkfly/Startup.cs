using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thinkfly.Startup))]
namespace Thinkfly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
