﻿using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class VillaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public int Occupancy { get; set; }
        public int sqft { get; set; }
    }
}
