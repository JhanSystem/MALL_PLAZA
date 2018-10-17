using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBIMallPlaza.Startup))]
namespace WebBIMallPlaza
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
