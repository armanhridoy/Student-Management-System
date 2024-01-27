﻿using AutoMapper;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.ViewModel;
[AutoMap(typeof(Student),ReverseMap = true)]
public class StudentVm
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public  string Name { get; set; } = string.Empty;
    public  string Email { get; set; } = default!;
    public  string Phone { get; set; } = string.Empty;
    public  string Address { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public string Photo { get; set; }
}
