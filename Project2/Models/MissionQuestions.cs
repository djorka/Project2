using Project2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

//Model based on MissionQuestions Database
//Has foreign keys pointing to the Missions and Users table
//Used to update questions database and keep track of who asked it and for what mission
namespace Project2.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        public int missionQuestionID { get; set; }
        public string question { get; set; }
        public string answer { get; set; }

        [ForeignKey("Missions")]
        public virtual int missionID { get; set; }
        public virtual Missions Missions { get; set; }

        [ForeignKey("Users")]
        public virtual int userID { get; set; }
        public virtual Users Users { get; set; }
    }
}