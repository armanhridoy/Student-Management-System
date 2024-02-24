using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.ModelConfigurtion;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
       builder.ToTable(nameof(Employee));
        builder.HasKey(e => e.Id);
        builder.Property(e => e.EmployeeName).HasMaxLength(50).IsRequired(true);
    }
}
