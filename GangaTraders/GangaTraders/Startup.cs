using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GangaTraders.Startup))]
namespace GangaTraders
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
