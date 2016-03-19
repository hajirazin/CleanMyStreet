using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CleanMyStreet.Web.Startup))]
namespace CleanMyStreet.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
