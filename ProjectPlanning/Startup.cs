using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectPlanning.Startup))]
namespace ProjectPlanning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
