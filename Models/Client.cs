using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CAP2.Models
{
    public class Client
    {
        public int ClientID {get; set;} //PK
        public string Name {get; set;} 
       
        [Display (Name = "E-mail")]
        [Required(ErrorMessage ="The Email field is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email {get;set;}

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
         public int TeamId {get;set;} //FK
        public Team Team {get;set;} //navigation


    }
}