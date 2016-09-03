using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web_matching.Startup))]
namespace web_matching
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
