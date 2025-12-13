using Microsoft.AspNetCore.Identity;

namespace Api.Models;

public class WorkLog
{
    // Attributes
    public int Id { get; set; }
    public string? Description { get; set; }
    public required string TaskId { get; set; }
    public required string UserId { get; set; }
    public required DateTime Date { get; set; }
    public required decimal Hours { get; set; }

    // Navigation properties
    public required ProjectTask Task { get; set; }
    public required User User { get; set; }
}