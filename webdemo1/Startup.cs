using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webdemo1.Startup))]
namespace webdemo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
