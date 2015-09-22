using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArduinoSerialWeb.Startup))]
namespace ArduinoSerialWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
