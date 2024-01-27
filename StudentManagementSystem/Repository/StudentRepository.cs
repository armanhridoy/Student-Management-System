using AutoMapper;
using StudentManagementSystem.DatabaseContext;
using StudentManagementSystem.Models;
using StudentManagementSystem.Service;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Repository;

public class StudentRepository(IMapper mapper, ApplicationDbContext dbcontext) : CommonService<Student, StudentVm>(mapper, dbcontext),IStudentRepository
{
}
