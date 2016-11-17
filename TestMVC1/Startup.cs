using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVC1.Startup))]
namespace TestMVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
