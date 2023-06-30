using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PassionProjectFlower.Models
{
    public class Bouquet
    {
        [Key]
        public int BouquetId { get; set; }

        public string BouquetName { get; set; }

        public string BouquetPrice { get; set; }

        public int FlowerDescription { get; set; }

    }
}