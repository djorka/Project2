using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

//Model representing missions database, ID is not an identity field
//Will need to find max id + 1 and assign that to missionID if adding new missions
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