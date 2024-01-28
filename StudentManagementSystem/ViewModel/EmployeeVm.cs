using AutoMapper;
using StudentManagementSystem.Controllers;

namespace StudentManagementSystem.ViewModel;
[AutoMap(typeof(Employee),ReverseMap =true)]
public class EmployeeVm
{
    public int Id { get; init; }
    public string EmployeeName { get; init; } = string.Empty;
    public int EmployeeId { get; init; }
    public string EmployeeInformation { get; init; } = string.Empty;
    public string Image { get; set; } = string.Empty;
}
