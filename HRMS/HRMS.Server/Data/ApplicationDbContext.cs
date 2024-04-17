using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Security.Cryptography;
using HRMS.Server.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Server.Data
{
    public class ApplicationDbContext :  IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Attendance> attendances { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Leave> leaves{ get; set; }
        public DbSet<Payroll> payrolls  { get; set; }
        public DbSet<Project> projects  { get; set; }
        public DbSet<Recruitment> reccruitments  { get; set; }
        public DbSet<Training> training{ get; set; }






        //public DbSet<ListingViewModel> listingVm { get; set; }
    }
}
