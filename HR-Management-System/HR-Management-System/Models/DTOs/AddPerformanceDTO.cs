﻿namespace HR_Management_System.Models.DTOs
{
    public class AddPerformanceDTO
    {
        public int EmployeeID { get; set; }
        public int Commitment { get; set; }
        public int Efficiency { get; set; }
        public int Communication { get; set; }
        public int TimeManagement { get; set; }
        public int QualityOfWork { get; set; }
    }
}
