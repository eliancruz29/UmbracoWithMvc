using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoWithMvc.Models;

namespace UmbracoWithMvc.Controllers
{
    public class ContactUsSurfaceController : SurfaceController
    {
        public ActionResult Index(ContactUsModel model)
        {
            return RedirectToCurrentUmbracoPage();
        }
    }
}