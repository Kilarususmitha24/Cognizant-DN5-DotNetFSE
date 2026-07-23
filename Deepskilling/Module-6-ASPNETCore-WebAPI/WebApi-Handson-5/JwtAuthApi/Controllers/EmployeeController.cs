using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private static readonly List<string> employees = new()
        {
            "John",
            "David",
            "Sai",
            "Susmitha"
        };

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            if (id < 1 || id > employees.Count)
                return NotFound();

            return Ok(employees[id - 1]);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (id < 1 || id > employees.Count)
                return NotFound();

            employees.RemoveAt(id - 1);

            return Ok("Employee Deleted Successfully");
        }
    }
}
