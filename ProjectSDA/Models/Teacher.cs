using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSDA.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        ////public int StudentId { get; set; }

        ////[ForeignKey("StudentId")]
        ////public Student? Student { get; set; }
        ///

        // constructor
        //public Teacher()
        //{
            
        //}






    }
}
