
namespace EmployeeManagementSystem.Services.FileStorage;

public class AWSFileStorageSettings
{
    public string AccessKeyId { get; set; }
    public string SecretAccessKey { get; set; }
    public string Region { get; set; }
    public string BucketName { get; set; }
}