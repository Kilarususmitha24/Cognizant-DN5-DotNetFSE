using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = GetStandardEmployeeList();

        private static List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1998,5,20),
                    Department = new Department
                    {
                        Id = 101,
                        Name = "IT"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill{ Id = 1, Name = "C#" },
                        new Skill{ Id = 2, Name = "ASP.NET Core" }
                    }
                },

                new Employee
                {
                    Id = 2,
                    Name = "David",
                    Salary = 45000,
                    Permanent = false,
                    DateOfBirth = new DateTime(2000,8,10),
                    Department = new Department
                    {
                        Id = 102,
                        Name = "HR"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill{ Id = 3, Name = "Communication" }
                    }
                }
            };
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Employee> Get(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
                return NotFound();

            return Ok(emp);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);

            return Created("", employee);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
                return NotFound();

            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.Permanent = employee.Permanent;
            emp.Department = employee.Department;
            emp.Skills = employee.Skills;
            emp.DateOfBirth = employee.DateOfBirth;

            return Ok(emp);
        }
    }
}
