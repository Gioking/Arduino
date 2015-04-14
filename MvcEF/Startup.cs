using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcEF.Startup))]
namespace MvcEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
