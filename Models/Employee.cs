namespace Basics.Models
{

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public int Age { get; set; }
    }

}