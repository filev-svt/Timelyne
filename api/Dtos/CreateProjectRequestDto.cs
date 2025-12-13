namespace Api.Dtos;

public class CreateProjectRequestDto
{
    public required string Name { get; set; }
    public required string Slug { get; set; }
    public decimal? HourlyRate { get; set; }
    public string? Description { get; set; }
}