using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Server.Model
{
    public class Training

    {
        public int TrainingId { get; set; }

        public string TrainingName { get; set; }    
        public string TrainingDescription { get; set; }
       
        public string TypeDescription { get; set; }
        public int MyProperty1 { get; set; }

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public String Status { get; set; }

        public int TraineeId { get; set; }
        [ForeignKey("TraineeId")]
        [Column("TraineeEmployeeId")]
        public Employee employeeTrainee { get; set; }
        public int TrainerId { get; set; }
        [ForeignKey("TrainerId")]
        [Column("TrainerEmployeeId")]
        public Employee employeeTrainer { get; set; }
    }
}
