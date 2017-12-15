using Project2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Models;
using System.Data.Entity;

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

        //User needs to be logged in in order to view mission info and FAQ page to answer and ask question
        [Authorize]
        public ActionResult FrequentQuestions(string MisName)
        {
            //Query used to fill FaqPage model that passes to mission FAQ view and displays mission info and mission questions
            IEnumerable<FaqPage> mission = db.Database.SqlQuery<FaqPage>("SELECT a.missionID, a.missionName, a.missionPresidentName, a. missionAddress, a.missionLanguage, a.missionClimate, a.missionDomReligion, a.missionFlagURL, c.missionQuestionID, c.question, c.answer, c.userID, b.userEmail\n"
           + "FROM Missions a, Users b, MissionQuestions c\n"
           + "WHERE a.missionID = c.missionID\n"
           + "AND c.userID = b.userID\n"
           + "AND a.missionName = '" + MisName + "'");

            //send model info to FrequentQuestions view
            return View(mission);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection form)
        {
            //assign form values to variables to be used in query
            string missionQuestionID = form[0].ToString();
            string missionID = form[1].ToString();
            string userID = form[2].ToString();
            string question = form[3].ToString();
            string answer = form[4].ToString();
            string missionName = form[5].ToString();

            //SQL query that updates answer info send to this action by the answer form on the FAQ page
            db.Database.ExecuteSqlCommand(
             "Update MissionQuestions Set answer = '" + answer + "'" + " where missionQuestionID = '" + missionQuestionID + "'");

            //refresh the FrequentQuestions page with updated answer to the question
            return RedirectToAction("FrequentQuestions", "Home", new { MisName = missionName });
        }

        [HttpPost]
        public ActionResult AddQuestion(FormCollection form)
        {
            //assign questionID by finding the max ID currently in the database and adding 1
            var questionID = db.MissionQuestions.Max(t => t.missionQuestionID) + 1;

            //assign form values to variables to be used in query
            string missionID = form[1].ToString();
            string userID = form[2].ToString();
            string question = form[3].ToString();
            string answer = form[4].ToString();
            string missionName = form[5].ToString();

            //SQL query to insert new question into MissionQuestions database using data from model already on page and question form values
            db.Database.ExecuteSqlCommand(
             "Insert into MissionQuestions "
           + "Values ('" + questionID + "', '" + missionID + "', '" + userID + "', '" + question + "', '" + answer + "')");

            //Refresh FrequentQuestions page with added question to the FAQ's
            return RedirectToAction("FrequentQuestions", "Home", new { MisName = missionName });
        }
    }
}