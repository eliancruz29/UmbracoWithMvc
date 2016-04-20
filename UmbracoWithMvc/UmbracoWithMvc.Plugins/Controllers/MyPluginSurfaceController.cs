using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoWithMvc.Plugins.Controllers
{
    [PluginController("UmbracoWithMvcPlugins")]
    public class MyPluginSurfaceController : SurfaceController
    {
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}
