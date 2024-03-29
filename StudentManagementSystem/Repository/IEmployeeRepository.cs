﻿using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagementSystem.Models;
using StudentManagementSystem.Service;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Repository;

public interface IEmployeeRepository : ICommonService<Employee,EmployeeVm>
{
    public IEnumerable<SelectListItem> DropDown();
}
