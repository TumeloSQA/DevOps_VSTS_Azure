using System.Web;
using System.Web.Http;

namespace DevOps_VSTS.WebApi
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
