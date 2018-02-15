using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoadMoreMVCSample.Startup))]
namespace LoadMoreMVCSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
