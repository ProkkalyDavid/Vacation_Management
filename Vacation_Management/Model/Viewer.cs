﻿using System.ComponentModel.DataAnnotations;

namespace Vacation_Management.Model
{
    public class Viewer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        

        
    }
}
