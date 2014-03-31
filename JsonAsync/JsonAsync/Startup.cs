using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JsonAsync.Startup))]
namespace JsonAsync
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
