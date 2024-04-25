using BlazorApp1.CarModels.Utils;
using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels
{
    public class SimpleEventType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string DisplayName
        {
            get { return Name.ToFriendlyCase(); }
        }
    }
}