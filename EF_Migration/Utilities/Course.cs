using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Migration.Utilities
{

    [Table(name: "Courses")]
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int TotalHours { get; set; }
        public Instructor instructor { get; set; } = null!;
        public SnapShot snapShot { get; set; } = null!;

    }
}