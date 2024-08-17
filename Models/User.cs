
using System;

namespace EmployeeManagementSystem.Models;

public class User {
    public int UserId { get; set; }
    public string FullName { get; set; }
    public string UserName { get; set; }
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string PictureUrl { get; set; }
    public int RoleId { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
    public string LastModifiedBy { get; set; } = "System";
    public DateTime LastLoginDate { get; set; }
    public bool IsActive { get; set; } = true;
}