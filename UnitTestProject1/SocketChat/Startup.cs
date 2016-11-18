using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocketChat.Startup))]
namespace SocketChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
