﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class Performance
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int Attendance { get; set; }
        public int Effeciency { get; set; }
        public int Communication { get; set; }
        public int TimeManagement { get; set; }
        public int QualityOfWork { get; set; }
        public int Overall { get; set; }
        public DateTime PerformanceDate { get; set; }
        public Employee Employee { get; set; } 
    }
}
 