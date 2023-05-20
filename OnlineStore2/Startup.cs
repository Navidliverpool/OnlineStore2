using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using OnlineStore2.Data.Repositories;
using OnlineStore2.Models;

[assembly: OwinStartupAttribute(typeof(OnlineStore2.Startup))]
namespace OnlineStore2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        public void ConfigureServices(IServiceCollection services)
        {
        }

    }
}
