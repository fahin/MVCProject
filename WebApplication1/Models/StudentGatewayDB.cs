using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace MVC_part1.Models
{
    public class StudentGatewayDB:DbContext
    {
        public StudentGatewayDB(): base("MvcFirstClass")
        {
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<District> Districts { set; get; }
        public DbSet<Thana> Thanas { set; get; }
        public DbSet<Centre> Centres { set; get; }
        public DbSet<Medicine> Medicines { set; get; }
        public DbSet<MedicineOrder> MedicineOrders { set; get; }
        //   public DbSet<Disease> Diseases { set; get; }
    }
}