using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(blog_CRUD.Startup))]
namespace blog_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
