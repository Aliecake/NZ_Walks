using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZ_WalksAPI.Controllers
{
    // https://localhost:port/api/students

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: https://localhost:port/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "John", "Jane", "Emily", "David" };
            return Ok(studentNames);
        }
    }
}
