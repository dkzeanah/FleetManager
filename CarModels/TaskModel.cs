﻿namespace BlazorApp1.CarModels 
{ 
    public class TaskModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Task { get; set; }
        public bool IsComplete { get; set; }
        public int Importance { get; set; }
    }
}
