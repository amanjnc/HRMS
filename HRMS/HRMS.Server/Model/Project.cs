namespace HRMS.Server.Model
{
    public class Project
    {
        public int ProjectId {  get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateOnly ProjectStartDate { get; set; }
        public DateOnly ProjectEndDate { get; set; }

        public  String Status { get; set; }
    
}
}
