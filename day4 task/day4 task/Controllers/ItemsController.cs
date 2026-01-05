using day4_task.Models;
using Microsoft.AspNetCore.Mvc;

namespace day4_task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private static readonly List<Item> _items = new();
        private static int _idCounter = 1;


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_items); // 200
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                if (id <= 0)
                    return BadRequest("Invalid ID"); // 400

                var item = _items.FirstOrDefault(i => i.Id == id);

                if (item == null)
                    return NotFound(); // 404

                return Ok(item); // 200
            }
            catch (Exception)
            {
                return StatusCode(500, "Unexpected error occurred");
            }
        }

        // POST: api/items
        [HttpPost]
        public IActionResult Create(Item item)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState); // 400

                item.Id = _idCounter++;
                _items.Add(item);

                return CreatedAtAction(
                    nameof(GetById),
                    new { id = item.Id },
                    item); // 201
            }
            catch (Exception)
            {
                return StatusCode(500, "Unexpected error occurred");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Item updatedItem)
        {
            try
            {
                if (id <= 0)
                    return BadRequest("Invalid ID"); // 400

                if (!ModelState.IsValid)
                    return BadRequest(ModelState); // 400

                var existingItem = _items.FirstOrDefault(i => i.Id == id);

                if (existingItem == null)
                    return NotFound(); // 404

                existingItem.Title = updatedItem.Title;
                existingItem.Description = updatedItem.Description;

                return NoContent(); // 204
            }
            catch (Exception)
            {
                return StatusCode(500, "Unexpected error occurred");
            }
        }
    }
}
