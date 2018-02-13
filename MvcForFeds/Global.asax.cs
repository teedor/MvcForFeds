using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MvcForFeds.Models;

namespace MvcForFeds
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start()
        {
            Session["Feds"] = new List<FedViewModel>
            {
                new FedViewModel
                {
                    Id = 1,
                    FirstName = "Harry",
                    LastName = "Potter",
                    FavouriteThing = "Long boring movies",
                    Rating = 2,
                    Dislikes = new List<string>
                    {
                        "Flying broomsticks",
                        "baddies",
                        "black cats"
                    },
                    DateOfBirth = new DateTime(1989, 7, 23)
                },
                new FedViewModel
                {
                    Id = 2,
                    FirstName = "Charles",
                    LastName = "Manson",
                    FavouriteThing = "LSD, hippie chicks, and orchestrating murders to throw the popo's scent off other murders",
                    Rating = 3,
                    Dislikes = new List<string>
                    {
                        "Peanut butter",
                        "Marmite"
                    },
                    DateOfBirth = new DateTime(1934, 11, 12)
                },
                new FedViewModel
                {
                    Id = 3,
                    FirstName = "Brad",
                    LastName = "Pitt",
                    FavouriteThing = "Used to be Anagelina Jolie - not so sure now.",
                    Rating = 4,
                    Dislikes = new List<string>
                    {
                        "Ikea-boy",
                        "dirty t-shirts",
                        "clowns"
                    },
                    DateOfBirth = new DateTime(1963, 12, 18)
                }
            };
        }
    }
}
