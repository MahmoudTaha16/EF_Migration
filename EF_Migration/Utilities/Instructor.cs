

using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Migration.Utilities
{
    //the Instrructor Model
    [Table(name: "Instructors")]
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal salary { get; set; } 

    } 
}