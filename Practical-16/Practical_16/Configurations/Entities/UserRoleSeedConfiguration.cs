using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Practical_16.Configuartions.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {

            builder.HasData(
                new IdentityUserRole<string>
                {
                     RoleId = "094afa8c-69e3-4103-a542-8aee12940f9a",
                    UserId = "5b2546a3-3e7a-454e-ac18-52d4cae97b2f"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "9f074bba-372c-474e-81a2-92e877a73075",
                     UserId = "4b2546a3-3e7a-424e-ac18-52d4cae97b2f"
                 }
                );
        }
    }
}