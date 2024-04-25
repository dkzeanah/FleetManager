using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class CheckListItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CarId { get; set; }
        public Car Car { get; set; } // Navigation property to the Car
                                     // TestRelease association (optional, if applicable)
        public int? TestReleaseId { get; set; }
        public TestRelease TestRelease { get; set; } // Navigation property to the TestRelease

        [Required]
        [StringLength(255)]
        public string Title { get; set; } // A brief title or description of the checklist item

        public string Description { get; set; } // Detailed description of the checklist item

        [Required]
        public bool IsCompleted { get; set; } = false; // Indicates if the item has been completed


        public string Notes { get; set; } // Any additional notes or comments

        // Optional: Priority of the checklist item (Low, Medium, High)
        public PriorityLevel Priority { get; set; } = PriorityLevel.Medium;

        // Optional: Due date for the checklist item
        public DateTime? TargetDate { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        
        // Flag to indicate if this is a generic item applicable to all cars
        public bool IsGeneric { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        //public bool IsCompleted { get; set; } = false;

    }

    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }

}
