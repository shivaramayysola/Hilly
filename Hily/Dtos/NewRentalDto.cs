using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hily.Dtos;
using Hily.Models;


namespace Hily.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}