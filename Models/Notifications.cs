
using System;

namespace EmployeeManagementSystem.Models;

public class Notification
{
    public int NotificationId { get; set; }
    public int EmployeeId { get; set; }
    public string Message { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public string LastModifiedBy { get; set; }
    public bool IsReaded { get; set; }
}