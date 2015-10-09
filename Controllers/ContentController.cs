using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;
using YMCA.Application.Services;
using YMCA.Domain.Models.API;
using YMCA.Domain.Models.Repositories;

namespace YMCA.WebUI.Areas.YMCA.Content.Controllers
{
    public class ContentController : GlassController
    {
        public ActionResult LocationMap()
        {
            // TODO: This View probably needs to be loaded via a parent rather than directly like this.
            var centresRepository = RepositoryFactory.GetRepository<IRepository<Centre, int>>();
            var centre = centresRepository.FindBy(5);
            return View(centre);
        }
    }
}