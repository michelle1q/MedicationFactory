using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PharmaFactory.Startup))]
namespace PharmaFactory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
