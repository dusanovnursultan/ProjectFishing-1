using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectFishing.Models
{
    public class Lakes
    {
        [Key]
        public string LakeId { get; set; }
        public string NameOfLake { get; set; }
        public string Location { get; set; }
        public string WaterTemperatureBySeasons { get; set; }
        public string QualityOfWater { get; set; }

    }
}