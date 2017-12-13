using Project2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace New_Project_2.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        public int questionID { get; set; }
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