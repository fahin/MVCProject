using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class Centre
    {
        public int CentreID { set; get; }
        [Required(ErrorMessage = "Center name is required")]
        [Remote("ExisCenter", "Centre")]
        public string Name { set; get; }
        public int ThanaID { get; set; }
        public int DistrictID { set; get; }
        public virtual Thana Thana { get; set; }
        public virtual District District { get; set; }
       

    }
}