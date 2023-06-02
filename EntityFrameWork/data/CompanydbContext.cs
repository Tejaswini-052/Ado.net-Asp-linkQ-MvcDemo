using EntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols;

namespace EntityFrameWork.data
{
    public class CompanydbContext:DbContext
    {
        public DbSet<Employee> Employee { get; set; } = null!;
        public DbSet<Department> Department { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer(GetConnection());
            //@"Data Source=LAPTOP-JAO9IL68\SQLEXPRESS ; Initial Catalog=CompanyDB;Integrated Security= true; TrustServerCertificate=True;"
            // ConfigurationManager.connectionStrings["DefaultConnection"].connectionString
        }
        private static string GetConnection()
        {
            string connect = @"Data Source=LAPTOP-JAO9IL68\SQLEXPRESS ; Initial Catalog=CompanyDB;Integrated Security= true; TrustServerCertificate=True;";
            return connect;
        }

    }
}
