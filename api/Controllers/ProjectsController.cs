using System.ComponentModel.DataAnnotations;
using Api.Dtos;
using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
public class ProjectsController
(ProjectRepository projectRepository, UserManager<User> userManager)
 : ControllerBase
{
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> CreateProject([FromBody] CreateProjectRequestDto request)
    {
        var createdProject = await projectRepository.CreateProject(new Project
        {
            Name = request.Name,
            Slug = request.Slug,
            OwnerId = userManager.GetUserId(User) ?? throw new ValidationException("User not found"),
            HourlyRate = request.HourlyRate,
            Description = request.Description,
        });

        return CreatedAtAction(nameof(GetProject), new { id = createdProject.Id }, createdProject);
    }

    [HttpGet("{id:int}")]
    [Authorize]
    public async Task<IActionResult> GetProject(int id)
    {
        var project = await projectRepository.GetProjectById(id); 
        
        if (project is null)
        {
            return NotFound();
        }

        return Ok(project);
    }

}