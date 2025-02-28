﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Hily.Models;

namespace Hily.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

       
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType{ get; set; }

  //      [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}