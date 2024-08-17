
using System;

namespace EmployeeManagementSystem.Models;

public class Employee {
    public int EmployeeId { get; set; }
    public string EmployeeCode { get; set; } // Código de empleado
    public string FullName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string JobTitle { get; set; } // Puesto de trabajo
    public int DepartmentId { get; set; } // DepartmentId es el Id del departamento al que pertenece el empleado
    public int ManagerId { get; set; } // ManagerId es el Id del empleado que es el jefe de este empleado
    public WorkMode WorkMode { get; set; } = WorkMode.Onsite;
    public DateTime HireDate { get; set; } = DateTime.UtcNow; //Fecha de contratación
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "System";
    public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
    public string LastModifiedBy { get; set; } = "System";
}