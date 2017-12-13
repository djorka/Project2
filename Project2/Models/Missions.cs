using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    [Table("Missions")]
    public class Missions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int missionID { get; set; }
        public string missionName { get; set; }
        public string missionPresidentName { get; set; }
        public string missionAddress { get; set; }
        public string missionLanguage { get; set; }
        public string missionClimate { get; set; }
        public string missionDomReligion { get; set; }
        public string missionFlagURL { get; set; }
    }
}