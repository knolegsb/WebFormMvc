using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormMvc.Startup))]
namespace WebFormMvc
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
