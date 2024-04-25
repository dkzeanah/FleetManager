namespace BlazorApp1.CarModels
{
    public class UserEventDetail : Detail, IEventDetail
    {
        public int GetDetailId() => UserEventDetailId;
        public string? GetNote() => Note;

        public string? UserId { get; set; }

        public int? UserEventId { get; set; }
        public int UserEventDetailId { get; set; }

        public UserEvent? UserEvent { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public string? Note { get; set; }

    }

    public class NoteEventDetail : UserEventDetail
    {
        //
    }
    //public virtual List<NoteEventDetail> Note { get; set; }

    public class ErrorEventDetail : UserEventDetail
    {
        public string Note { get; set; }
    }
    // Error-specific property
    // public virtual List<ErrorEventDetail> ErrorSummary { get; set; }

    public class ContactEventDetail : UserEventDetail
    {
        public string Note { get; set; }
    }
    // public virtual List<NoteEventDetail>? ContactInfo { get; set; }


}