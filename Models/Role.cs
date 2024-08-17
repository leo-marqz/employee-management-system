
using System;

namespace EmployeeManagementSystem.Models;

public class Role
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
    public string LastModifiedBy { get; set; } = "System";
    public bool IsActive { get; set; } = true;
}