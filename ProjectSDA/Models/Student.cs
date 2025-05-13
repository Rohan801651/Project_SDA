using System.ComponentModel.DataAnnotations;

namespace ProjectSDA.Models
{
    public class Student
    {
        //[Key]
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public int StudentAccountId { get; set; }
        public StudentAccount? StudentAccount { get; set; }


    }
}
