using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mitphiliapps.Startup))]
namespace mitphiliapps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
