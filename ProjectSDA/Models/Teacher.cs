namespace ProjectSDA.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        public Teacher(int id, string name, string email, string subject)
        {
            Id = id;
            Name = name;
            Email = email;
            Subject = subject;
        }





    }
}
