namespace StudentApiWithVersioning.Models.Dtos.V1_1
{
    public class StudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string City { get; set; }
    }
}
