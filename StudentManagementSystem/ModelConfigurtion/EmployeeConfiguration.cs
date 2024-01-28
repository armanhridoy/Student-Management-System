using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementSystem.Controllers;

namespace StudentManagementSystem.ModelConfigurtion;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
       builder.ToTable(nameof(Employee));
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasMaxLength(50).IsRequired(true);
    }
}
