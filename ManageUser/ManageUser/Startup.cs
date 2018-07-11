using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManageUser.Startup))]
namespace ManageUser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
