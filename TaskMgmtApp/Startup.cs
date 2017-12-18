using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskMgmtApp.Startup))]
namespace TaskMgmtApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
