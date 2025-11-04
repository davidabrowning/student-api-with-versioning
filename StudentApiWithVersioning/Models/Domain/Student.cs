using Microsoft.AspNetCore.StaticAssets;

namespace StudentApiWithVersioning.Models.Domain
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string City { get; set; }
    }
}
