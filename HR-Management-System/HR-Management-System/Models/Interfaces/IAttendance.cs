﻿using HR_Management_System.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HR_Management_System.Models.Interfaces
{
    public interface IAttendance
    {
        public Task<AttendanceDTO> GetAttendance(int id);
        public Task<List<AttendanceDTO>> GetAttendances();
        public Task Arrival(int id);
        public Task Leave(int id);
        public Task UpdateAttendance(int id, Attendance attendance);
        public Task DeleteAttendance(int id);
        public void Test1();
        public Task TakeAttendance();
        public Task<List<AttendanceDTO>> GetAllAttendance(int id);
        public Task<List<AttendanceDTO>> GetAllAttendancesInADateForEmployee(int id, int year, int month);
        public Task<List<AttendanceDTO>> GetAllAttendancesInADate(int year, int month);
    }
}