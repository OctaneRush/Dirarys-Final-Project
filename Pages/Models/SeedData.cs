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
                        Name = ""
                        Age = 
                        Height = 
                        Weight = 
                        Race = ""
                        Specialization = ""
                        Land = 
                        Guild = 
                    }
                );

                context.LandOfOrigins.AddRange(
                    new LandOfOrigin
                    {
                        Name = ""
                        Climate = ""
                        GoverningType = ""
                        Characters = new List<Character> {

                        }
                    }
                );

                context.Guilds.AddRange(
                    new Guild
                    {
                        Name = ""
                        MoralAlignment = ""
                        Characters = new List<Character> {

                        }
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}