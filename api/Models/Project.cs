using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Api.Models;

public class Project
{
    // Attributes
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Slug { get; set; }
    public decimal? HourlyRate { get; set; }
    public string? Description { get; set; }
    public required string OwnerId { get; set; }

    // Navigation properties (managed by EF Core, not required on creation)
    public User Owner { get; set; }

    [InverseProperty("ProjectsAdmin")]
    public List<User> Admins { get; set; } = [];

    [InverseProperty("ProjectsMember")]
    public List<User> Members { get; set; } = [];

    [InverseProperty("ProjectsWatcher")]
    public List<User> Watchers { get; set; } = [];
}