using System.Web.Mvc;

namespace Areas.Areas.Site3
{
    public class Site3AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Site3";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Site3_default",
                "Site3/{controller}/{action}/{id}",
                new { areas = "Site3", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}