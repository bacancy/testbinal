using System.Web.Mvc;

namespace YMCA.WebUI.Areas.YMCA.Content
{
    public class ContentAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "YMCA/Content";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Content_default",
                "Content/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}