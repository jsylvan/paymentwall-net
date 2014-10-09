using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(paymentwall_net.Startup))]
namespace paymentwall_net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
