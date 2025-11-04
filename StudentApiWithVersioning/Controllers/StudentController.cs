using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApiWithVersioning.Models.Dtos.V1_0;

namespace StudentApiWithVersioning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<StudentDto> _students;

        public StudentController()
        {
            _students = new()
            {
                new StudentDto()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 50,
                }
            };
        }

        [HttpGet]
        public IEnumerable<StudentDto> GetStudents()
        {
            return _students;
        }
    }
}
