using AutoMapper;
using StudentManagementSystem.Controllers;
using StudentManagementSystem.DatabaseContext;
using StudentManagementSystem.Service;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Repository;

public class EmployeeRepository : CommonService<Employee, EmployeeVm>, IEmployeeRepository
{
    public EmployeeRepository(IMapper mapper, ApplicationDbContext dbcontext) : base(mapper, dbcontext)
    {
    }
}
