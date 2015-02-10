using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Centre
    {
        public int CentreID { set; get; }
        public string Name { set; get; }
        public int ThanaID { get; set; }
        public int DistrictID { set; get; }
        public virtual Thana Thana { get; set; }
        public virtual District District { get; set; }
       

    }
}