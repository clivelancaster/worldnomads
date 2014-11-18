using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NumSeqCalc.Web.Startup))]
namespace NumSeqCalc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
