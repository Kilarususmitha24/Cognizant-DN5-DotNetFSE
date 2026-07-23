using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private static readonly List<string> Values = new()
        {
            "Value One",
            "Value Two",
            "Value Three"
        };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(Values);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= Values.Count)
                return NotFound();

            return Ok(Values[id]);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            Values.Add(value);

            return Ok("Value Added Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            if (id < 0 || id >= Values.Count)
                return NotFound();

            Values[id] = value;

            return Ok("Value Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= Values.Count)
                return NotFound();

            Values.RemoveAt(id);

            return Ok("Value Deleted Successfully");
        }
    }
}
