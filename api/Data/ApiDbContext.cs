using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Data;

public class ApiDbContext(
    DbContextOptions<ApiDbContext> options
) : IdentityDbContext<IdentityUser>(options)
{
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectTask> ProjectTasks { get; set; }
    public DbSet<ProjectTaskStatus> ProjectTaskStatuses { get; set; }
    public DbSet<WorkLog> WorkLogs { get; set; }
}