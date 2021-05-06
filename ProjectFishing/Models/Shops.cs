using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectFishing.Models
{
    public class Shops
    {
        [Key]
        public string ShopId { get; set; }
        public string ShopName { get; set; }
        public double Rating { get; set; }
        public string Reviews { get; set; }
        public DateTime WorkingHours { get; set; }
        public string Contacts { get; set; }
    }
}