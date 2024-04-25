using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class UserEvent
    {
        [Key]
        public int Id { get; set; }

        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        #region Navs

        //has 1 user with many userevents
        public string? UserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public int? UserCarEventId { get; set; }
        //public virtual ICollection<UserCarEvent>? Events { get; set; }
        public virtual UserCarEvent? UserCarEvent { get; set; }


        public int? ApplicationUserDetailId { get; set; }
        public ApplicationUserDetail? ApplicationUserDetail { get; set; }
        //many to many events and userevents. all events contain the many individual user events, userevents are apart of specific events, and all of them...
        public int? UserEventDetailId { get; set; }
        public virtual ICollection<UserEventDetail>? UserEventDetails { get; set; }
        //public int? StatusId { get; set; }
        //public virtual ICollection<Status>? Statuses { get; set; }
        #endregion

    }

}
