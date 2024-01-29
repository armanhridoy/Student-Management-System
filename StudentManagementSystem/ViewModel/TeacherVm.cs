using AutoMapper;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.ViewModel;
[AutoMap(typeof(Teacher), ReverseMap = true)]
public class TeacherVm
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
}
