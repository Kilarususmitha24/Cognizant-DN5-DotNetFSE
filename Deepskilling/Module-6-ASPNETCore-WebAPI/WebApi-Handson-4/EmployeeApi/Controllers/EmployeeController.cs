using EmployeeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = new()
    {
        new Employee
        {
            Id = 1,
            Name = "John",
            Salary = 50000,
            Permanent = true,
            DateOfBirth = new DateTime(1999,5,10),
            Department = new Department
            {
                Id = 1,
                Name = "IT"
            },
            Skills = new List<Skill>
            {
                new Skill{Id=1,Name="C#"},
                new Skill{Id=2,Name="SQL"}
            }
        },

        new Employee
        {
            Id = 2,
            Name = "David",
            Salary = 45000,
            Permanent = false,
            DateOfBirth = new DateTime(2000,8,15),
            Department = new Department
            {
                Id = 2,
                Name = "HR"
            },
            Skills = new List<Skill>
            {
                new Skill{Id=3,Name="Communication"}
            }
        }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Employee>> Get()
    {
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
            return NotFound();

        return Ok(employee);
    }

    [HttpPost]
    public IActionResult Post(Employee employee)
    {
        employees.Add(employee);

        return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Employee employee)
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

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var emp = employees.FirstOrDefault(e => e.Id == id);

        if (emp == null)
            return NotFound();

        employees.Remove(emp);

        return Ok("Employee Deleted Successfully");
    }
}
