using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bio_Book.Startup))]
namespace Bio_Book
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
