using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class InformationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-D5IEUUD\\SQLEXPRESS;database=random_information;integrated security=true;");

        }
        public DbSet<Truth> Games { get; set; }
        public DbSet<Dare> Games2 { get; set; }

    }
}
