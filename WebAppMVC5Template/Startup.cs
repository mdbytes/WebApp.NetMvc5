using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppMVC5Template.Startup))]
namespace WebAppMVC5Template
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
