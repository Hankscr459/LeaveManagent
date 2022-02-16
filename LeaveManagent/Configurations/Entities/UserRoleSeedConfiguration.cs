using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagent.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "da115585-33b1-1354-94b3-5d6bcabeb51a",
                    UserId = "af1155f5-b121-225a-a43d-5a6a11beb522"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bb115775-33b1-5434-34a1-ad1b12beb5fa",
                    UserId = "43122545-c122-115f-c66a-4a6a11b81a1c"
                }
            );
        }
    }
}