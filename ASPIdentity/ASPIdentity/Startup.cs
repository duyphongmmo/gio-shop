using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPIdentity.Startup))]
namespace ASPIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
