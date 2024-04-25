﻿namespace BlazorApp1.CarModels
{
    public class TeamTimeline
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public List<UserCarEvent> Events { get; set; }
    }
}
