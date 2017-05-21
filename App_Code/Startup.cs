using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsAngular.Startup))]
namespace WebFormsAngular
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
