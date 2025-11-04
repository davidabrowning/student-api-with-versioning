using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApiWithVersioning.Models.Dtos.V1_0;
using StudentApiWithVersioning.Models.Dtos.V1_1;

namespace StudentApiWithVersioning.Controllers
{
    // [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    [Route("api/v{version:apiVersion}/students")]
    public class StudentController : ControllerBase
    {

        [HttpGet]
        [MapToApiVersion("1.0")]
        public IEnumerable<Models.Dtos.V1_0.StudentDto> GetStudentsV1_0()
        {
            List<Models.Dtos.V1_0.StudentDto> students = new();
            students.Add(new Models.Dtos.V1_0.StudentDto()
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 50,
            });
            return students;
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        public IEnumerable<Models.Dtos.V1_1.StudentDto> GetStudentsV1_1()
        {
            List<Models.Dtos.V1_1.StudentDto> students = new();
            students.Add(new Models.Dtos.V1_1.StudentDto()
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateOnly(1950, 12, 25),
                City = "New York",
            });
            return students;
        }
    }
}
