﻿namespace StudentManagementSystem.Models;

public class Employee
{
    public int Id { get; init; }
    public string EmployeeName { get; init; } = string.Empty;
    public int EmployeeId { get; init; }
    public string EmployeeInformation { get; init; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public ICollection<Student> Students { get; init; }=new HashSet<Student>();
}
