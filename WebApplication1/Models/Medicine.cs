using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Medicine
    {
        public int MedicineID { set; get; }
       [DisplayName("Medicine Name")]
        public string MedidineName { set; get; }
        [DisplayName( "Power")]
        public string Power { set; get; }
      // public virtual ICollection<Disease> Diseases { set; get; }
    }
}