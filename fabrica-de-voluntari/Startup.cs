using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fabrica_de_voluntari.Startup))]
namespace fabrica_de_voluntari
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
