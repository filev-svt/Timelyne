using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Api.Models;

public class User : IdentityUser
{
    // Navigation properties
    [InverseProperty("Owner")]
    public required List<Project> ProjectsOwned { get; set; }

    [InverseProperty("Admins")]
    public required List<Project> ProjectsAdmin { get; set; }

    [InverseProperty("Members")]
    public required List<Project> ProjectsMember { get; set; }

    [InverseProperty("Watchers")]
    public required List<Project> ProjectsWatcher { get; set; }

    [InverseProperty("Assignees")]
    public required List<ProjectTask> TasksAssigned { get; set; }
    public required List<WorkLog> WorkLogs { get; set; }
}