namespace StudentManagementSystem.ViewModel;

public class StudentVm
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public required string Name { get; set; } = string.Empty;
    public required string Email { get; set; } = default!;
    public required string Phone { get; set; } = string.Empty;
    public required string Address { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public string Photo { get; set; }
}
