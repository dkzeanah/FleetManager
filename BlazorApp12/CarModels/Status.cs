using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.CarModels
{

    public partial class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}