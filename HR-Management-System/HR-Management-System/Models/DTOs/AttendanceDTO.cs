﻿using System;

namespace HR_Management_System.Models.DTOs
{
    public class AttendanceDTO
    {
        public int EmployeeID { get; set; }
        public DateTime Date { get; set; }
        public bool Present { get; set; }


    }
}
