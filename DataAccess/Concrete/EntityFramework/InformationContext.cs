using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class InformationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=DESKTOP-D5IEUUD\\SQLEXPRESS;database=random_information;integrated security=true;");
            //optionsBuilder.UseSqlServer("server=DESKTOP-D5IEUUD\\MSSQLSERVER2022;database=poldipo_project;integrated security=true;");
            optionsBuilder.UseSqlServer("server=DESKTOP-D5IEUUD\\MSSQLSERVER2022;database=bidijital_medya;integrated security=true;");
        }

        public DbSet<Truth> Games { get; set; }
        public DbSet<Dare> Games2 { get; set; }
        public DbSet<bidijital_contact> Contacts { get; set; }
    }
}
