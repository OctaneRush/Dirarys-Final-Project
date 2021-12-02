using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Dirarys_Final_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CharacterDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<CharacterDbContext>>()))
            {
                // Look for any characters.
                if (context.Characters.Any() && context.LandOfOrigins.Any() && context.Guilds.Any())
                {
                    return; // db seeded.
                }
                
                context.Characters.AddRange(
                    new Character
                    {
                        Name = "Rilathan Gilrora",
                        Age = 22,
                        Height = 1.8,
                        Weight = 81.6,
                        Race = "Human",
                        Specialization = "One-Handed"
                    },
                    new Character
                    {
                        Name = "Tibnan Dorcan",
                        Age = 30,
                        Height = 2.2,
                        Weight = 108.8,
                        Race = "Orc",
                        Specialization = "Two-Handed"
                    },
                    new Character
                    {
                        Name = "Dernall Gilnelis",
                        Age = 45,
                        Height = 1.4,
                        Weight = 90.7,
                        Race = "Dwarf",
                        Specialization = "Two-Handed"
                    },
                    new Character
                    {
                        Name = "Vanfin Carmys",
                        Age = 105,
                        Height = 1.7,
                        Weight = 86.2,
                        Race = "Wood Elf",
                        Specialization = "Bow"
                    },
                    new Character
                    {
                        Name = "Fridolin Brownlock",
                        Age = 37,
                        Height = 1.1,
                        Weight = 45.3,
                        Race = "Halfling",
                        Specialization = "Stealth"
                    },
                    new Character
                    {
                        Name = "Gnursalb",
                        Age = 42,
                        Height = 1.3,
                        Weight = 54.4,
                        Race = "Goblin",
                        Specialization = "Dual-Weild"
                    },
                    new Character
                    {
                        Name = "Clagrog",
                        Age = 85,
                        Height = 5.5,
                        Weight = 544.3,
                        Race = "Giant",
                        Specialization = "Two-Handed"
                    },
                    new Character
                    {
                        Name = "Kieran Valleth",
                        Age = 150,
                        Height = 2.0,
                        Weight = 86.1,
                        Race = "High Elf",
                        Specialization = "Magic"
                    },
                    new Character
                    {
                        Name = "Balrach Qinvalur",
                        Age = 25,
                        Height = 1.9,
                        Weight = 88.4,
                        Race = "Half-Elf",
                        Specialization = "One-Handed"
                    },
                    new Character
                    {
                        Name = "Toneak Leofir",
                        Age = 34,
                        Height = 1.85,
                        Weight = 87.5,
                        Race = "Human",
                        Specialization = "Magic"
                    },
                    new Character
                    {
                        Name = "Dunvairs",
                        Age = 52,
                        Height = 2.1,
                        Weight = 110.5,
                        Race = "Orc",
                        Specialization = "Sword and Shield"
                    },
                    new Character
                    {
                        Name = "Thathuri Forgehelm",
                        Age = 34,
                        Height = 1.35,
                        Weight = 89.4,
                        Race = "Dwarf",
                        Specialization = "Dual-Weild"
                    },
                    new Character
                    {
                        Name = "Vaeril Daecan",
                        Age = 130,
                        Height = 1.67,
                        Weight = 88.3,
                        Race = "Wood Elf",
                        Specialization = "One-Handed"
                    },
                    new Character
                    {
                        Name = "Eracle Longfoot",
                        Age = 72,
                        Height = 1.12,
                        Weight = 47.8,
                        Race = "Halfling",
                        Specialization = "Bow"
                    },
                    new Character
                    {
                        Name = "Lerkilx",
                        Age = 23,
                        Height = 1.24,
                        Weight = 52.1,
                        Race = "Goblin",
                        Specialization = "Stealth"
                    },
                    new Character
                    {
                        Name = "Figom",
                        Age = 57,
                        Height = 5.4,
                        Weight = 510.3,
                        Race = "Giant",
                        Specialization = "Sword and Shield"
                    },
                    new Character
                    {
                        Name = "Zeno Lurel",
                        Age = 110,
                        Height = 1.94,
                        Weight = 83.6,
                        Race = "High Elf",
                        Specialization = "One-Handed"
                    },
                    new Character
                    {
                        Name = "Gibelor Miafir",
                        Age = 41,
                        Height = 2.05,
                        Weight = 89.7,
                        Race = "Half-Elf",
                        Specialization = "Two-Handed"
                    },
                    new Character
                    {
                        Name = "Brakhak",
                        Age = 27,
                        Height = 1.94,
                        Weight = 90.4,
                        Race = "Half-Orc",
                        Specialization = "Dual-Weild"
                    },
                    new Character
                    {
                        Name = "Edxian Yelfaren",
                        Age = 31,
                        Height = 1.94,
                        Weight = 89.7,
                        Race = "Human",
                        Specialization = "Bow"
                    },
                    new Character
                    {
                        Name = "Warron Kriskas",
                        Age = 43,
                        Height = 2.1,
                        Weight = 94.3,
                        Race = "Half-Elf",
                        Specialization = "One-Handed"
                    },
                    new Character
                    {
                        Name = "Halgol Darkhead",
                        Age = 45,
                        Height = 1.38,
                        Weight = 95.7,
                        Race = "Dwarf",
                        Specialization = "Sword and Sheild"
                    },
                    new Character
                    {
                        Name = "Vidarok",
                        Age = 37,
                        Height = 2.15,
                        Weight = 107.4,
                        Race = "Orc",
                        Specialization = "Two-Handed"
                    },
                    new Character
                    {
                        Name = "Kurnir",
                        Age = 48,
                        Height = 5.7,
                        Weight = 530.8,
                        Race = "Giant",
                        Specialization = "Two-Handed"
                    },
                    new Character
                    {
                        Name = "Nulno",
                        Age = 32,
                        Height = 1.82,
                        Weight = 82.6,
                        Race = "Half-Orc",
                        Specialization = "Bow"
                    },
                    new Character
                    {
                        Name = "Shelara Neriren",
                        Age = 85,
                        Height = 1.85,
                        Weight = 81.2,
                        Race = "High Elf",
                        Specialization = "Magic"
                    },
                    new Character
                    {
                        Name = "Perlaer Magdove",
                        Age = 57,
                        Height = 1.59,
                        Weight = 77.3,
                        Race = "Wood Elf",
                        Specialization = "Stealth"
                    }
                );

                context.LandOfOrigins.AddRange(
                    new LandOfOrigin
                    {
                        Name = "Agria",
                        Climate = "Polar",
                        GoverningType = "Republic",
                        Characters = new List<Character> {

                        }
                    },
                    new LandOfOrigin
                    {
                        Name = "Eshuyca",
                        Climate = "Temperate",
                        GoverningType = "Aristocracy",
                        Characters = new List<Character> {

                        }
                    },
                    new LandOfOrigin
                    {
                        Name = "Podrad",
                        Climate = "Dry",
                        GoverningType = "Empire",
                        Characters = new List<Character> {

                        }
                    },
                    new LandOfOrigin
                    {
                        Name = "Troetan",
                        Climate = "Continental",
                        GoverningType = "Monarchy",
                        Characters = new List<Character> {

                        }
                    }
                );

                context.Guilds.AddRange(
                    new Guild
                    {
                        Name = "Explorers",
                        MoralAlignment = "Neutral",
                        Characters = new List<Character> {

                        }
                    },
                    new Guild
                    {
                        Name = "Craftsman",
                        MoralAlignment = "Good",
                        Characters = new List<Character> {

                        }
                    },
                    new Guild
                    {
                        Name = "Merchant",
                        MoralAlignment = "Neutral",
                        Characters = new List<Character> {

                        }
                    },
                    new Guild
                    {
                        Name = "Warrior",
                        MoralAlignment = "Good",
                        Characters = new List<Character> {

                        }
                    },
                    new Guild
                    {
                        Name = "Mages",
                        MoralAlignment = "Good",
                        Characters = new List<Character> {

                        }
                    },
                    new Guild
                    {
                        Name = "Assassins",
                        MoralAlignment = "Evil",
                        Characters = new List<Character> {

                        }
                    },
                    new Guild
                    {
                        Name = "Thieves",
                        MoralAlignment = "Neutral",
                        Characters = new List<Character> {

                        }
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}