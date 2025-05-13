using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSDA.Models
{
    // One to One relationship with Student and StudentAccount

    public class StudentAccount
    {
        [Key]
        public int RegNo { get; set; }
        public string UserName { get; set; }
        public string email { get; set; }
        public double phone { get; set; }
        public string City { get; set; }

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }


    }
}
