using Api.Data;
using Api.Models;

namespace Api.Repositories;

public class ProjectRepository(ApiDbContext context)
{
    public async Task<Project> CreateProject(Project project)
    {
        context.Projects.Add(project);
        await context.SaveChangesAsync();
        return project;
    }

    public async Task<Project?> GetProjectById(int id)
    {
        return await context.Projects.FindAsync(id) ?? null;
    }
}