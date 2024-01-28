using System;
using System.ComponentModel.DataAnnotations;

public class Project
{
    public int ProjectId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? ProjectStatus { get; set; }

    public Project()
    {
    }

    public Project(int projectId, string name, string description)
    {
        ProjectId = projectId;
        Name = name;
        Description = description;
    }
}