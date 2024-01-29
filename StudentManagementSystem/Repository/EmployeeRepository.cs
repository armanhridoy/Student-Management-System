using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagementSystem.DatabaseContext;
using StudentManagementSystem.Models;
using StudentManagementSystem.Service;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Repository;

public class EmployeeRepository : CommonService<Employee, EmployeeVm>, IEmployeeRepository
{
    public EmployeeRepository(IMapper mapper, ApplicationDbContext dbcontext) : base(mapper, dbcontext)
    {
    }

    public IEnumerable<SelectListItem> DropDown()
    {
       return DbSet.Select(x=>new SelectListItem { Text=x.EmployeeName,Value=x.Id.ToString()});
    }
}
