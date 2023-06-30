using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PassionProjectFlower.Models
{
    public class Flower
    {
        [Key]
        public int FlowerId { get; set; }

        public string FlowerName { get; set; }

        public string FlowerColor { get; set; }

        public int FlowerPrice { get; set; }

        public string FlowerPic { get; set; }
    }
}