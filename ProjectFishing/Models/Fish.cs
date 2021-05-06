using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectFishing.Models
{
    public class Fish
    {
        [Key]
        public string FishId { get; set; }
        public string NameOfFish { get; set; }
        public string ClassificationOfFish { get; set; }
        public string  Description { get; set; }
        public string Size { get; set; }
        public byte[] Photo { get; set; }
        public string Habitats { get; set; }
        public string Baits { get; set; }
        public string FishingMethod { get; set; }
        public string SpawningTime { get; set; }
    }
}