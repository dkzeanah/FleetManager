﻿namespace BlazorApp1.CarModels
{
    public class TicketTag
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public string Tag { get; set; }
    }
}