using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BTTuan5.Startup))]
namespace BTTuan5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
