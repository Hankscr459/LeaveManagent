namespace LeaveManagent.Models
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }
        public int NumbeOfDays { get; set; }
        public int Period { get; set; }
        public LeaveTypeVM LeaveType { get; set; }
    }
}
