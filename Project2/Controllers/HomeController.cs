using Project2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        private MissionSiteContext db = new MissionSiteContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult FrequentQuestions(string MisName)
        {
            IEnumerable<FaqPage> mission = db.Database.SqlQuery<FaqPage>("SELECT a.missionID, a.missionName, a.missionPresidentName, a. missionAddress, a.missionLanguage, a.missionClimate, a.missionDomReligion, a.missionFlagURL, c.missionQuestionID, c.question, c.answer, c.userID, b.userEmail\n"
           + "FROM Missions a, Users b, MissionQuestions c\n"
           + "WHERE a.missionID = c.missionID\n"
           + "AND c.userID = b.userID\n" 
           + "AND a.missionName = '" + MisName + "'");

            return View(mission);
        }


    }
}