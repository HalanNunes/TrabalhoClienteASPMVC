﻿using System.Web.Mvc;

namespace TrabalhoClienteASPMVC.Areas.Cliente
{
    public class ClienteAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Cliente";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Cliente_default",
                "Cliente/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
