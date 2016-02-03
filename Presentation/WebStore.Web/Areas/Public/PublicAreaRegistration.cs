using System.Web.Mvc;

namespace WebStore.Web.Areas.Public
{
    public class PublicAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Public";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Public_default",
                "{controller}/{action}/{id}",
                new { controller = "Product", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}