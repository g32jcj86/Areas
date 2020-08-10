using System.Web.Mvc;

namespace Areas.Areas.Site1
{
    public class Site1AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Site1";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Site1_default",
                "Site1/{controller}/{action}/{id}",
                new { areas = "Site1", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}