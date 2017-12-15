using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Model with a model approach for mission / user / questions
//model used to store query results containing mission info so that mission info and all of its questions can be stored in one view
namespace Project2.Models
{
    public class FaqPage
    {
        public int missionID { get; set; }
        public string missionName { get; set; }
        public string missionPresidentName { get; set; }
        public string missionAddress { get; set; }
        public string missionLanguage { get; set; }
        public string missionClimate { get; set; }
        public string missionDomReligion { get; set; }
        public string missionFlagURL { get; set; }
        public int missionQuestionID { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public int userID { get; set; }
        public string userEmail { get; set; }
        public string upadateAnswer { get; set; }
    }
}