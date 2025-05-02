using Kursach.Interfaces;
using Kursach.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kursach.Controllers
{
 
        [ApiController]
        [Route("api/achievs")]
        public class AchievsController : ControllerBase
        {
            private readonly IAchiev _AchievService;

            public AchievsController(IAchiev AchievService)
            {
                _AchievService = AchievService;
            }

            // GET: api/Achievs
            [HttpGet]
            public IActionResult GetAchievs()
            {
                var Achievs = _AchievService.GetAllAchievs();
                return Ok(Achievs);
            }

            // GET: api/Achievs/{id}
            [HttpGet("{id}")]
            public IActionResult GetAchiev(int id)
            {
                var Achiev = _AchievService.GetAchievById(id);
                if (Achiev == null)
                {
                    return NotFound();
                }
                return Ok(Achiev);
            }


            [HttpGet("titles/{title}")]
            public IActionResult GetAchievTitle(string title)
            {
                var Achiev = _AchievService.GetAchievByTitle(title);
                if (Achiev == null)
                {
                    return NotFound();
                }
                return Ok(Achiev);
            }

            // POST: api/Achievs
            [HttpPost]
            public IActionResult AddAchiev([FromBody] Achiev Achiev)
            {
                if (Achiev == null || string.IsNullOrEmpty(Achiev.Name))
                {
                    return BadRequest("Invalid Achiev data.");
                }

                var addedAchiev = _AchievService.AddAchiev(Achiev);
                return CreatedAtAction(nameof(GetAchiev), new { id = addedAchiev.Id }, addedAchiev);
            }

            // PUT: api/Achievs/{id}
            [HttpPut("{id}")]
            public IActionResult UpdateAchiev(int id, [FromBody] Achiev updatedAchiev)
            {
                var Achiev = _AchievService.UpdateAchiev(id, updatedAchiev);
                if (Achiev == null)
                {
                    return NotFound();
                }

                return NoContent();
            }

            // DELETE: api/Achievs/{id}
            [HttpDelete("{id}")]
            public IActionResult DeleteAchiev(int id)
            {
                _AchievService.DeleteAchiev(id);
                return NoContent();
            }
        }
    
}
