using Microsoft.AspNetCore.Mvc;
using modernSchoolForCD.Managers;
using modernSchoolForCD.Models;

namespace modernSchoolForCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private StudentsManager manager = new();

        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return manager.GetAll();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student? Get(int id)
        {
            return manager.GetById(id);
        }

        // POST api/<StudentsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Student> Post([FromBody] Student value)
        {
            try
            {
                Student st = manager.Add(value);
                string uri = Url.Action("Get", new { id = st.Id });
                return Created(uri, st);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
