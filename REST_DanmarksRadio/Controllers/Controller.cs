using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibary;
using REST_DanmarksRadio.Models;
using System.Reflection;

namespace REST_DanmarksRadio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DRController : ControllerBase
    {
        private IRepository _repository;

        public DRController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/DR
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }
        // GET: api/DR/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetById(int id)
        {
            var dr = _repository.GetById(id);
            if (dr == null)
            {
                return NotFound();
            }
            return Ok(dr);
        }

        [HttpGet("title/{title}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult GetByTitle(string title)
        {
            return Ok(_repository.GetByTitle(title));

        }

        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<DR> Add(DR dr)
        {
            var created = _repository.Add(dr);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DR> Delete(int id)
        {
            var deleted = _repository.Delete(id);
            if (deleted == null)
            {
                return NotFound();
            }
            return Ok(deleted);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DR> Update(int id, DR dr)
        {
            var updated = _repository.Update(id, dr);
            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }
    }
}

