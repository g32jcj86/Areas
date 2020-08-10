using System.Web.Mvc;

namespace Areas.Areas.Site2
{
    public class Site2AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Site2";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Site2_default",
                "Site2/{controller}/{action}/{id}",
                new { areas = "Site2", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}