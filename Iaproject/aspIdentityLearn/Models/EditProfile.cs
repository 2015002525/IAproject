using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspIdentityLearn.Models
{
    public class EditProfile
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }


        [Display(Name = "JobDescription")]
        public string JobDescription { get; set; }

        //public bool EmailConfirmed { get; set; }
        
    }
}

