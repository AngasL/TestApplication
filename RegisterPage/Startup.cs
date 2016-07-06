using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegisterPage.Startup))]
namespace RegisterPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
