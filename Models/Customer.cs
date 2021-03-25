using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Widly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        
        [Display(Name = "Date Of Birth")]
        [Min18Years]
        public DateTime? Birthdate { get; set; }

    }
}