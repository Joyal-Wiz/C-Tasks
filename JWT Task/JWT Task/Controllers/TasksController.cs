using JWT_Task.Data;
using JWT_Task.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    [Authorize] // 🔐 All endpoints require login
    public class TasksController : ControllerBase
    {
        // ✅ Both Admin & User can READ
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(FakeDb.Tasks);
        }

        // ✅ Both Admin & User can CREATE
        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            FakeDb.Tasks.Add(task);
            return Ok("Task created");
        }

        // 👑 Only Admin can UPDATE
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id, TaskItem updated)
        {
            var task = FakeDb.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
                return NotFound("Task not found");

            task.Title = updated.Title;
            return Ok("Task updated");
        }

        // 👑 Only Admin can DELETE
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var task = FakeDb.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
                return NotFound("Task not found");

            FakeDb.Tasks.Remove(task);
            return Ok("Task deleted");
        }
    }
}
