using EmployeeManagerMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagerMvc
{
    public class AppDbContext : DbContext
    {
        public AppDbContext([NotNllAtribute] DbContextOptions options): base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }

    }
}
