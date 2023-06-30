using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PassionProjectFlower.Models
{
    public class Occasion
    {
        [Key]
        public int OccasionId { get; set; }

        public string OccasionName { get; set; }

        public string OccasionDescription { get; set; }
    }
}