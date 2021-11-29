using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mall.Startup))]
namespace Mall
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
