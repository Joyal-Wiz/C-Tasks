using TaskManagementApi.Data;
using TaskManagementApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagementApi.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    [Authorize] // 🔐 Only authenticated users can access anything here
    public class TasksController : ControllerBase
    {
        // ✅ Admin & User can view all tasks
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(FakeDb.Tasks);
        }

        // ✅ Admin & User can view single task
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var task = FakeDb.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
                return NotFound("Task not found");

            return Ok(task);
        }

        // ✅ Admin & User can create
        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            FakeDb.Tasks.Add(task);
            return Ok("Task created");
        }

        // ✅ Admin & User can update
        [HttpPut("{id}")]
        public IActionResult Update(int id, TaskItem updated)
        {
            var task = FakeDb.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
                return NotFound("Task not found");

            task.Title = updated.Title;
            task.Description = updated.Description;
            task.Status = updated.Status;

            return Ok("Task updated");
        }

        // 👑 ONLY ADMIN CAN DELETE
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
