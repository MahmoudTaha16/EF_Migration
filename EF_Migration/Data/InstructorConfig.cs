using EF_Migration.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Migration.Data
{
    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {

            builder.ToTable("Instructors", "Co").HasKey(x => x.Id);
            builder.Property(x=>x.Id).IsRequired().UseIdentityColumn();
            builder.Property(x=>x.Address).HasMaxLength(255);
            builder.Property(x=>x.Name).HasMaxLength(50).IsRequired();



            builder.HasData(
                new[]
                {
                    new Instructor {Id=1, Name="Mahmoud", Address="Bajour",salary=30000m},
                    new Instructor {Id=2, Name="Taha", Address="shebin",salary=20000m},
                    new Instructor {Id=3, Name="Issam", Address="Menofia",salary=60000m}
                }

                );

        }
    }
}