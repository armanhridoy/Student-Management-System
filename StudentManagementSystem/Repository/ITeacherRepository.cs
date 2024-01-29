using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagementSystem.Models;
using StudentManagementSystem.Service;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Repository;

public interface ITeacherRepository : ICommonService<Teacher,TeacherVm>
{
    public IEnumerable<SelectListItem> Dropdown();
}
