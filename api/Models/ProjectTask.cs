using Microsoft.AspNetCore.Identity;

namespace Api.Models;

public class ProjectTask
{
    // Attributes
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required int Priority { get; set; }
    public required string ProjectId { get; set; }
    public required int TaskStatusId { get; set; }

    // Navigation properties
    public required Project Project { get; set; }
    public required ProjectTaskStatus TaskStatus { get; set; }
    public required List<IdentityUser> Assignees { get; set; }
}