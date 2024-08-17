
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem;

public class ApplicationDbContext : DbContext{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    
}