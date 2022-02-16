using LeaveManagent.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagent.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "af1155f5-b121-225a-a43d-5a6a11beb522",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "user@ADMINLOCALHOST.COM",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@assword"),
                    EmailConfirmed = true,
                },
                new Employee
                {
                    Id = "43122545-c122-115f-c66a-4a6a11b81a1c",
                    Email = "user@localhost.com",
                    NormalizedEmail = "user@ADMINLOCALHOST.COM",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "P@assword"),
                    EmailConfirmed = true,
                }
            );
        }
    }
}