using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dirarys_Final_Project.Models
{
    // Class for framework of each LandOfOrigin object.
    public class LandOfOrigin
    {
        // Land of origin attributes.
        public int LandOfOriginID {get; set;} // Primary Key
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Name {get; set;}
        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string Climate {get; set;}
        [StringLength(15, MinimumLength = 5)]
        [Required]
        public string GoverningType {get; set;}
        public List<Character> Characters {get; set;} // Navigation List
    }
}