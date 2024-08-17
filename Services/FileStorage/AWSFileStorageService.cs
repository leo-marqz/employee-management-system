
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Services.FileStorage;

public class AWSFileStorageService : IFileStorageService
{
    public AWSFileStorageService(AWSFileStorageSettings awsFileStorageSettings)
    {
        
    }

    public Task DeleteFile(string path, string container)
    {
        throw new System.NotImplementedException();
    }

    public Task<string> EditFile(byte[] content, string extension, string container, string path, string contentType)
    {
        throw new System.NotImplementedException();
    }

    public Task<string> SaveFile(byte[] content, string extension, string container, string contentType)
    {
        throw new System.NotImplementedException();
    }
}