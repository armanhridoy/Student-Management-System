using StudentManagementSystem.Controllers;
using StudentManagementSystem.Service;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Repository;

public interface IEmployeeRepository : ICommonService<Employee,EmployeeVm>
{
}
