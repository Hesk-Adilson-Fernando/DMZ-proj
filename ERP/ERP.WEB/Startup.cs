using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ERP.WEB.Startup))]
namespace ERP.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
