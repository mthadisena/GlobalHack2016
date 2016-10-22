using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomelessHelper.Startup))]
namespace HomelessHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
