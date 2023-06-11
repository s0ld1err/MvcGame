using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGame.Data;
using System;
using System.Linq;


namespace MvcGame.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcGameContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcGameContext>>()))
            {
                // Look for any games.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "Dying Light",
                        ReleaseDate = DateTime.Parse("2015-1-26"),
                        Genre = "First-person, Survival, Action, Parkour",
                        Platforms = "PC, Playstation, Xbox, Nintendo",
                        Price = 9.99M
                    },

                    new Game
                    {
                        Title = "Metro Exodus ",
                        ReleaseDate = DateTime.Parse("2019-2-14"),
                        Genre = "First-person shooter, Survival, Adventure",
                        Platforms = "PC, Playstation, Xbox",
                        Price = 29.99M
                    },

                    new Game
                    {
                        Title = "Assassin's Creed Origins",
                        ReleaseDate = DateTime.Parse("2019-10-27"),
                        Genre = "ARPG, Stealth",
                        Platforms = "PC, Playstation, Xbox",
                        Price = 19.99M
                    },

                    new Game
                    {
                        Title = "Darksiders",
                        ReleaseDate = DateTime.Parse("2010-1-5"),
                        Genre = "Action-adventure, Hack and slash",
                        Platforms = "PC, Playstation, Xbox, Nintendo",
                        Price = 9.99M
                    },

                    new Game
                    {
                        Title = "Darksiders 2",
                        ReleaseDate = DateTime.Parse("2012-8-14"),
                        Genre = "Action-adventure, Hack and slash, RPG",
                        Platforms = "PC, Playstation, Xbox, Nintendo",
                        Price = 9.99M
                    },

                    new Game
                    {
                        Title = "Darksiders 3",
                        ReleaseDate = DateTime.Parse("2018-11-27"),
                        Genre = "Action-adventure, Hack and slash, RPG",
                        Platforms = "PC, Playstation, Xbox, Nintendo",
                        Price = 19.99M
                    },

                    new Game
                    {
                        Title = "Red Dead Redemption 2",
                        ReleaseDate = DateTime.Parse("2018-10-26"),
                        Genre = "Open world, Western, Adventure, Story Rich",
                        Platforms = "PC, Playstation, Xbox",
                        Price = 29.99M
                    },

                    new Game
                    {
                        Title = "God of War",
                        ReleaseDate = DateTime.Parse("2018-4-20"),
                        Genre = "Action-adventure, Combat, Mythology, RPG",
                        Platforms = "Playstation, PC",
                        Price = 29.99M
                    },

                    new Game
                    {
                        Title = "God of War Ragnarok",
                        ReleaseDate = DateTime.Parse("2022-11-9"),
                        Genre = "Action-adventure, Combat, Mythology, RPG",
                        Platforms = "Playstation",
                        Price = 59.99M
                    },

                    new Game
                    {
                        Title = "Grand Theft Auto V",
                        ReleaseDate = DateTime.Parse("2015-4-15"),
                        Genre = "Open World, Action, Multiplayer, Singleplayer, Shooter",
                        Platforms = "PC, Playstation, Xbox",
                        Price = 29.99M
                    },

                    new Game
                    {
                        Title = "Dark Souls 3",
                        ReleaseDate = DateTime.Parse("2016-4-11"),
                        Genre = "Souls-like, Dark Fantasy, Difficult, RPG, Atmospheric, Lore-Rich",
                        Platforms = "PC, Playstation, Xbox",
                        Price = 59.99M
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
