using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagementSystem.DatabaseContext;
using StudentManagementSystem.Models;
using StudentManagementSystem.Service;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Repository;

public class TeacherRepository(IMapper mapper, ApplicationDbContext dbcontext) : CommonService<Teacher, TeacherVm>(mapper, dbcontext), ITeacherRepository
{
    public IEnumerable<SelectListItem> Dropdown()
    {
       return DbSet.Select(x=> new SelectListItem { Text = x.Name,Value=x.Id.ToString() }); 
    }
}
