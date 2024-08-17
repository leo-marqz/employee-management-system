
using System;

namespace EmployeeManagementSystem.Models;

public class Vacation
{
    public int VacationId { get; set; } // Primary key
    public int EmployeeId { get; set; } // Foreign key to Employee
    public DateTime StartDate { get; set; } // Start date of the vacation
    public DateTime EndDate { get; set; } // End date of the vacation
    public DateTime RequestDate { get; set; } // Date the vacation was requested
    public bool IsApproved { get; set; } = false; // Is the vacation approved
    public string ApprovedBy { get; set; } // Name of the person who approved the vacation
    public DateTime ApprovedDate { get; set; } // Date the vacation was approved
}