using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_SV01.Startup))]
namespace Web_SV01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
