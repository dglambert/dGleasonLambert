using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dGleasonLambert.Startup))]
namespace dGleasonLambert
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
