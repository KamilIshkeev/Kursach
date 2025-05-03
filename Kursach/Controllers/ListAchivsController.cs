using Kursach.Interfaces;
using Kursach.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kursach.Controllers
{
    [ApiController]
    [Route("api/ListAchievs")]
    public class ListAchievsController : ControllerBase
    {
        private readonly IListAchiev _ListAchievservice;

        public ListAchievsController(IListAchiev ListAchievservice)
        {
            _ListAchievservice = ListAchievservice;
        }

        // GET: api/ListAchievs
        [HttpGet]
        public IActionResult GetListAchievs()
        {
            var ListAchievs = _ListAchievservice.GetAllListAchievs();
            return Ok(ListAchievs);
        }

        // GET: api/ListAchievs/{id}
        [HttpGet("{id}")]
        public IActionResult GetListAchiev(int id)
        {
            var ListAchiev = _ListAchievservice.GetListAchievById(id);
            if (ListAchiev == null)
            {
                return NotFound();
            }
            return Ok(ListAchiev);
        }


        [HttpGet("titles/{title}")]
        public IActionResult GetListAchievUserId(int user_id)
        {
            var ListAchiev = _ListAchievservice.GetListAchievByUserId(user_id);
            if (ListAchiev == null)
            {
                return NotFound();
            }
            return Ok(ListAchiev);
        }

        // POST: api/ListAchievs
        [HttpPost]
        public IActionResult AddListAchiev([FromBody] ListAchiev ListAchiev)
        {
            if (ListAchiev == null)
            {
                return BadRequest("Invalid ListAchiev data.");
            }

            var addedListAchiev = _ListAchievservice.AddListAchiev(ListAchiev);
            return CreatedAtAction(nameof(GetListAchiev), new { id = addedListAchiev.Id }, addedListAchiev);
        }

        // PUT: api/ListAchievs/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateListAchiev(int id, [FromBody] ListAchiev updatedListAchiev)
        {
            var ListAchiev = _ListAchievservice.UpdateListAchiev(id, updatedListAchiev);
            if (ListAchiev == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/ListAchievs/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteListAchiev(int id)
        {
            _ListAchievservice.DeleteListAchiev(id);
            return NoContent();
        }
    }
}
