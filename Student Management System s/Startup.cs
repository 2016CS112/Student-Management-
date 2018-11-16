using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Student_Management_System_s.Startup))]
namespace Student_Management_System_s
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
