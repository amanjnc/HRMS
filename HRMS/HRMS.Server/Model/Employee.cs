using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Server.Model
{
    public class Employee

    {
        public int EmployeeId { get; set; } 
        public String  EmployeeFullName { get; set; }   
        public int EmployeeAge { get; set; }
        public DateOnly EmployyDOB { get; set; }
        public DateOnly EmployeeHiredDate{ get; set; }

        public String EmployeeAddress { get; set; }
        public int EmployeePhone { get; set; }
        public String EmployeeEmail { get; set; }









        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentID")]
        publicDepartment Department { get; set; }


        public int ProjectId;
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }


        public int PayrollId();
        [ForeignKey("PayrollId")]

        public Payroll payroll { get; set; }
    }
}
