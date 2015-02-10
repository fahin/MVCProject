using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class District
    {
        public int DistrictID { get; set; }
       
        public string Name { get; set; }
        public virtual ICollection<Centre> Centres { set; get; } 
    }
}