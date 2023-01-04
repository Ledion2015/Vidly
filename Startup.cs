using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestVidly.Startup))]
namespace TestVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
