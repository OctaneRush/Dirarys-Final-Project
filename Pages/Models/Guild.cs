using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dirarys_Final_Project.Models
{
    // Class for framework of each Guild object.
    public class Guild
    {
        // Guild attributes.
        public int GuildID {get; set;} // Primary Key
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Name {get; set;}
        [StringLength(7, MinimumLength = 4)]
        [Required]
        public string MoralAlignment {get; set;}
        public List<Character> Characters {get; set;} // Navigation List
    }
}