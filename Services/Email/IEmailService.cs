
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Services.Email;

public interface IEmailService
{
    Task<bool> SendEmailAsync(string to, string subject, string htmlMessage);
    Task<bool> SendEmailAsync(string from, string to, string subject, string htmlMessage);
}