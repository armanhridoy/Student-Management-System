namespace StudentManagementSystem.Models;

public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }=string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;

    public ICollection<Student> Students { get; set; }=new HashSet<Student>();
}
