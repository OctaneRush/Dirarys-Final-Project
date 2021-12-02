using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dirarys_Final_Project.Models
{
    // Class for framework of each Character object.
    public class Character
    {
        // Character attributes.
        public int CharacterID {get; set;} // Primary Key
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Name {get; set;}
        [Required]
        public int Age {get; set;}
        [Range(0.50, 15.00)]
        [Required]
        public float Height {get; set;}
        [Range(0.50, 900.00)]
        public float Weight {get; set;}
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Race {get; set;}
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Specialization {get; set;}
        public int LandID {get; set;} // Foreign Key
        public LandOfOrigin Land {get; set;} // Reference Object
        public int GuildID {get; set;} // Foreign Key
        public Guild Guild {get; set;} // Reference Object
    }
}