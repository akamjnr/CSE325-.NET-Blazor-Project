
using System.ComponentModel.DataAnnotations;

namespace TaskTrack.Models;

public class TaskItem
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter a task title.")]
    [StringLength(100, ErrorMessage = "The title cannot exceed 100 characters.")]
    public string Title { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "The description cannot exceed 500 characters.")]
    public string Description { get; set; } = string.Empty;

    [Required]
    public string Priority { get; set; } = "Medium";

    [DataType(DataType.Date)]
    public DateTime? DueDate { get; set; }

    public bool IsCompleted { get; set; }

    // The authenticated user's ID is assigned when saving.
    public string UserId { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
