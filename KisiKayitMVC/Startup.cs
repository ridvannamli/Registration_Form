using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KisiKayitMVC.Startup))]
namespace KisiKayitMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
