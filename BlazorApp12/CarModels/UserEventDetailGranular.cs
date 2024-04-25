namespace BlazorApp1.CarModels
{
    public class UserEventDetailGranular : Detail
    {
        //public int Id { get; set; }
        public string Text { get; set; }


        public string? UserId { get; set; }

        public int? UserEventId { get; set; }
        public int UserEventDetailId { get; set; }

        public UserEventDetail? UserEventDetail { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public string? Note { get; set; }


    }
    public class NoteEventDetail : UserEventDetailGranular
    {
        //
    }
    //public virtual List<NoteEventDetail> Note { get; set; }

    public class ErrorEventDetail : UserEventDetailGranular
    {
        public string Note { get; set; }
    }
    // Error-specific property
    // public virtual List<ErrorEventDetail> ErrorSummary { get; set; }

    public class ContactEventDetail : UserEventDetailGranular
    {
        public string Note { get; set; }
    }
    // public virtual List<NoteEventDetail>? ContactInfo { get; set; }

}