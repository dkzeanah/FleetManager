using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels;

public class Issue
{
   
    public int IssueId { get; set; }
    public string Summary { get; set; }
    public string Status { get; set; }
    public string Priority { get; set; }
    public string AssignedTo { get; set; }
    public string System { get; set; }
    public string ModifiedBy { get; set; }
    public string ModifiedAt { get; set; }
    public string ModifiedByUser { get; set; }
    public string SubmittedBy { get; set; }
    public string SubmittedAt { get; set; }
}
