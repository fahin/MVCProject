using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class Thana
    {
        public int ThanaID { get; set; }
        [Required(ErrorMessage = "Thana name is required")]
        [Remote("ExisThana","Thana")]
        public string Name { get; set; }
       
        public int DistrictID { get; set; }

        public virtual ICollection<Centre> Centres { set; get; }
       
    }
}