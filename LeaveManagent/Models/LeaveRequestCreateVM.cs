﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagent.Models
{
    public class LeaveRequestCreateVM
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public SelectList LeaveTypes { get; set; }
        public string RequestComments { get; set; }
    }
}
