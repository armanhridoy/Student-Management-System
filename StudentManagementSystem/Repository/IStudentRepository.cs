using StudentManagementSystem.Models;
using StudentManagementSystem.Service;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Repository;

public interface IStudentRepository:ICommonService<Student,StudentVm>
{
}
