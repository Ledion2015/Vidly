using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TestVidly.Models;

namespace TestVidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Customer's name. ")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }


        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }


        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}