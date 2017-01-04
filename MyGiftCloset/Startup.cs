using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGiftCloset.Startup))]
namespace MyGiftCloset
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
