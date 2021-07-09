using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaiTapTuan4.Startup))]
namespace BaiTapTuan4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
