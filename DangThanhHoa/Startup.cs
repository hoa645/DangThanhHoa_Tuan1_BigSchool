using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DangThanhHoa.Startup))]
namespace DangThanhHoa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
