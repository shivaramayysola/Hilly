using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hily.Startup))]
namespace Hily
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
