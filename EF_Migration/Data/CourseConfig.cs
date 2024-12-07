using EF_Migration.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Migration.Data
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
         
            builder.ToTable("Courses","Co").HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(255);
            builder.Property(x => x.TotalHours).IsRequired();
           
        }
    }
}