using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITCallegari.Startup))]
namespace ITCallegari
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
