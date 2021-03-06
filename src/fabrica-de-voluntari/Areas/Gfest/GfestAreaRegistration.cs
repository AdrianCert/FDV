﻿using System.Web.Mvc;

namespace fabrica_de_voluntari.Areas.Gfest
{
    public class GfestAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Gfest";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Gfest_default",
                "Gfest/{controller}/{action}/{id}",
                new {controller="Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "fabrica_de_voluntari.Areas.Gfest.Controllers" }

            );
        }
    }
}