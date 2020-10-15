using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RevistiaTP.Startup))]
namespace RevistiaTP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
