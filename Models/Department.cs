
using System;

namespace EmployeeManagementSystem.Models;

public class Department
{
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
    public string LastModifiedBy { get; set; } = "System";
    public bool IsActive { get; set; } = true;
}