using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Optimus.Startup))]
namespace Optimus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
