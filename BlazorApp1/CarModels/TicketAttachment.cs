﻿namespace BlazorApp1.CarModels
{
    public class TicketAttachment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public string FilePath { get; set; }
    }
}
