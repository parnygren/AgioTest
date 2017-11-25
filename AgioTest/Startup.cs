using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgioTest.Startup))]
namespace AgioTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
