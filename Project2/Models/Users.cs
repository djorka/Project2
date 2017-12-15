using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

//Model for users table, used to extract user info from google api and assign it to variables and store in database
namespace Project2.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int userID { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public string userFirstName { get; set; }
        public string userLastName { get; set; }
    }
}