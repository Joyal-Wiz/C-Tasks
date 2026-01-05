using System.ComponentModel.DataAnnotations;

namespace day4_task.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}
