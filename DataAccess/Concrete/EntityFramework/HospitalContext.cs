using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class HospitalContext : DbContext
    {
        //Veritabanına bağlantı sağladım. Veritabanı adı Hospital
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JFG6RPD\SQLEXPRESS; Database=Hospital; Trusted_Connection=true;");
        }

        //Burada ise tabloların eşleştirmesini yaptım.
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Equipment> Equipments { get; set; }

    }
}