using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class District
    {
        public int DistrictID { get; set; }
       [Required(ErrorMessage = "District name is required")]
       [Remote("ExisDistrict","District")]
        public string Name { get; set; }
        public virtual ICollection<Centre> Centres { set; get; } 
    }
}