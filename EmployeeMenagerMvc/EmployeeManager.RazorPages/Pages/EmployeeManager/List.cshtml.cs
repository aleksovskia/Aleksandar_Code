using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManager.RazorPages.Pages.EmployeeManager
{
    public class ListModel : PageModel
    {
        private readonly AppDbContext db = null;
        public List<Employee> Employees { get; set; }

        public ListModel(AppDbContext _db)
        {
            this.db = _db;
        }
        public void OnGet()
        {
            this.Employees = (from e in db.Employees orderby e.EmployeeId select e).ToList();
        }
    }
}
