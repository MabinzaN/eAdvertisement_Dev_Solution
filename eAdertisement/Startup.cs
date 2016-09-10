using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eAdertisement.Startup))]
namespace eAdertisement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
