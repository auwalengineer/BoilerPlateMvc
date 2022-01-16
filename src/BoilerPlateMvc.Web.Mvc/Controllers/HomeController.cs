using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using BoilerPlateMvc.Controllers;

namespace BoilerPlateMvc.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BoilerPlateMvcControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
