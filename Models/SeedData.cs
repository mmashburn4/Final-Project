using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;


namespace Final_Project.Models{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if(context.RecordLabels.Any())
                {
                    return;
                }
                context.RecordLabels.AddRange
                (
                    new RecordLabel 
                    {
                        Name="Universal Music Group", 
                        Description="Universal Music Group N.V. is a Dutch-American multinational music corporation.",
                        Artists = new List<Artist> 
                        {
                            new Artist {Name="Drake", Genre="Hip-Hop/Rap", Age=35},
                            new Artist {Name="Olivia Rodrigo", Genre="Pop", Age=18},
                            new Artist {Name="The Weeknd", Genre="R&B/Soul", Age=31},
                            new Artist {Name="Taylor Swift", Genre="Pop", Age=31},
                            new Artist {Name="Ariana Grande", Genre="Pop", Age=28},
                            new Artist {Name="Justin Bieber", Genre="Pop", Age=27},
                            new Artist {Name="Billie Eilish", Genre="Alternative", Age=19},
                            new Artist {Name="Lil Baby", Genre="Hip-Hop/Rap", Age=27},
                            new Artist {Name="Bad Bunny", Genre="Latin", Age=27},
                            new Artist {Name="Kanye West", Genre="Hip-Hop/Rap", Age=44},
                            new Artist {Name="Post Malone", Genre="Hip-Hop/Rap", Age=26},
                            new Artist {Name="Chris Stapleton", Genre="Country", Age=43},
                            new Artist {Name="Kali Uchis", Genre="Latin", Age=27}
                        }
                    },
                    new RecordLabel
                    {
                        Name="Sony Music Entertainment",
                        Description="Sony Music Entertainment, also known as Sony Music, is an American global music company.",
                        Artists = new List<Artist> 
                        {
                            new Artist {Name="Doja Cat", Genre="R&B/Soul", Age=26},
                            new Artist {Name="Luke Combs", Genre="Country", Age=31},
                            new Artist {Name="The Kid LAROI", Genre="Hip-Hop/Rap", Age=18},
                            new Artist {Name="Lil Nas X", Genre="Hip-Hop/Rap", Age=22},
                            new Artist {Name="J. Cole", Genre="Hip-Hop/Rap", Age=36},
                            new Artist {Name="Harry Styles", Genre="Pop", Age=27},
                            new Artist {Name="Giveon", Genre="R&B/Soul", Age=26},
                            new Artist {Name="SZA", Genre="R&B/Soul", Age=31},
                            new Artist {Name="H.E.R.", Genre="R&B/Soul", Age=24},
                            new Artist {Name="Miley Cyrus", Genre="Pop", Age=29}

                        }
                    },
                    new RecordLabel
                    {
                        Name="Warner Music Group",
                        Description="Warner Music Group Corp. is an American multinational entertainment and record label conglomerate.",
                        Artists = new List<Artist> 
                        {
                            new Artist {Name="Dua Lipa", Genre="Pop", Age=26},
                            new Artist {Name="Megan Thee Stallion", Genre="Hip-Hop/Rap", Age=26},
                            new Artist {Name="Ed Sheeran", Genre="Pop", Age=30},
                            new Artist {Name="Young Thug", Genre="Hip-Hop/Rap", Age=30},
                            new Artist {Name="Cardi B", Genre="Hip-Hop/Rap", Age=29},
                            new Artist {Name="Jack Harlow", Genre="Hip-Hop/Rap", Age=23},
                            new Artist {Name="Bruno Mars", Genre="Pop", Age=36},

                        }
                    }
                );
                context.SaveChanges(); 
            }
        }
    }
}