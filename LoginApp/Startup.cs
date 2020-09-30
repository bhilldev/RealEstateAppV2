using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealEstateApp2.Startup))]
namespace RealEstateApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
