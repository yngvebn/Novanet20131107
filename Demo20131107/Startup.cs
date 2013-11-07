using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo20131107.Startup))]
namespace Demo20131107
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
