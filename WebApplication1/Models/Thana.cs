using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Thana
    {
        public int ThanaID { get; set; }
        public string Name { get; set; }
       
        public int DistrictID { get; set; }

        public virtual ICollection<Centre> Centres { set; get; }
       
    }
}