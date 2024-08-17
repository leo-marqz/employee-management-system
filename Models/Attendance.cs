
using System;

namespace EmployeeManagementSystem.Models;

public class Attendance
{
    public int AttendanceId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime CheckInTime { get; set; } // This is the time when the employee checks in
    public DateTime CheckOutTime { get; set; } // This is the time when the employee checks out
    public bool IsSick { get; set; } // This is true if the employee is sick
    public string SickNoteURL { get; set; } // This is the URL of the sick note
    public string AbsenceReason { get; set; } // This is the reason for the absence
    public DateTime RecoveryEndDate { get; set; } // This is the date when the employee is expected to recover
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime LastModifiedDate { get; set; } // This is the date when the record was last modified
    public string LastModifiedBy { get; set; }
}