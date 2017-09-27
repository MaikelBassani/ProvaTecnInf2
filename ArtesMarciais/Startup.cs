using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArtesMarciais.Startup))]
namespace ArtesMarciais
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
