using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VCart.Web2.Startup))]
namespace VCart.Web2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
