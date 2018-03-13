using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TruyenOnline.Startup))]
namespace TruyenOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
