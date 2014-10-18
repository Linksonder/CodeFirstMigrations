using CodeFirstMigrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstMigrations.Controllers
{
    public class PersonController : Controller
    {
        /// <summary>
        /// Mijn private field naar PersonContext
        /// </summary>
        private PersonContext context;

        public PersonController()
        {
            //Ik initialiseer dit object in de constructor
            context = new PersonContext();
        }

        public ActionResult Index()
        {
            //Ik heb alleen een view met een lijst van mensen
            return View(context.People.ToList());
        }

    }
}
