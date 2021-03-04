using GameStore.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.DAL.EntityConfiguration
{
    public static class Initializer
    {
        public static void GenreSeed(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                        new Genre()
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Strategy"
                        },
                        new Genre()
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "RPG"
                        },
                        new Genre()
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Sports"
                        },
                        new Genre()
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Races"
                        },
                        new Genre()
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Action"
                        },
                        new Genre()
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "Adventure"
                        },
                        new Genre()
                        {
                            Id = 7,
                            IsDeleted = false,
                            Name = "Puzzle & Skill"
                        },
                        new Genre()
                        {
                            Id = 8,
                            IsDeleted = false,
                            Name = "Misc."
                        },
                        new Genre()
                        {
                            Id = 9,
                            IsDeleted = false,
                            Name = "RTS",
                            ParentGenreId = 1
                        },
                        new Genre()
                        {
                            Id = 10,
                            IsDeleted = false,
                            Name = "TBS",
                            ParentGenreId = 1
                        },
                        new Genre()
                        {
                            Id = 11,
                            IsDeleted = false,
                            Name = "Rally",
                            ParentGenreId = 4
                        },
                        new Genre()
                        {
                            Id = 12,
                            IsDeleted = false,
                            Name = "Arcade",
                            ParentGenreId = 4
                        },
                        new Genre()
                        {
                            Id = 13,
                            IsDeleted = false,
                            Name = "Formula",
                            ParentGenreId = 4
                        },
                        new Genre()
                        {
                            Id = 14,
                            IsDeleted = false,
                            Name = "Off-road",
                            ParentGenreId = 4
                        },
                        new Genre()
                        {
                            Id = 15,
                            IsDeleted = false,
                            Name = "FPS",
                            ParentGenreId = 5
                        },
                        new Genre()
                        {
                            Id = 16,
                            IsDeleted = false,
                            Name = "TPS",
                            ParentGenreId = 5
                        });
        }

        public static void PlatformTypeSeed(EntityTypeBuilder<PlatformType> builder)
        {
            builder.HasData(
                new PlatformType()
                {
                    Id = 1,
                    IsDeleted = false,
                    Type = "Mobile"
                },
                new PlatformType()
                {
                    Id = 2,
                    IsDeleted = false,
                    Type = "Desktop"
                },
                new PlatformType()
                {
                    Id = 3,
                    IsDeleted = false,
                    Type = "Browser"
                },
                new PlatformType()
                {
                    Id = 4,
                    IsDeleted = false,
                    Type = "Console"
                });
        }
        public static void GameSeed(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                new Game()
                {
                    Id = 1,
                    IsDeleted = false,
                    Discontinued = false,
                    Key = "GTA V",
                    Name = "Grand Theft Auto V and Criminal Enterprise Starter Pack Bundle",
                    Description = "Rockstar Games ESRB Rating M - Mature 17 + DRM Rockstar Games Social Club Purchase this bundle to get Grand Theft Auto V and the Criminal Enterprise Starter Pack for Grand Theft Auto Online. Please do not purchase this bundle if you already own the Criminal Enterprise Starter Pack",
                    Price = 45,
                    UnitsInStock = 5,
                    PublisherId = 1
                },
                new Game()
                {
                    Id = 2,
                    IsDeleted = false,
                    Discontinued = false,
                    Key = "FF XIV",
                    Name = "Final Fantasy XIV: Shadowbringers - Standard Edition PC",
                    Description = "Please note that the FINAL FANTASY XIV: SHADOWBRINGERS expansion pack also includes FINAL FANTASY XIV: HEAVENSWARD & FINAL FANTASY XIV: STORMBLOOD. This package requires FINAL FANTASY XIV Online Starter Edition (A Realm Reborn) to play the game. Notice: This product is not compatible with the Steam DRM",
                    Price = 35,
                    UnitsInStock = 8,
                    PublisherId = 2
                },
                new Game()
                {
                    Id = 3,
                    IsDeleted = false,
                    Discontinued = false,
                    Key = "COD G",
                    Name = "Call of Duty: Ghosts PC Game",
                    Description = "Activision M - Mature Genre First Person Shooter",
                    Price = 32,
                    UnitsInStock = 3,
                    PublisherId = 3
                },
                new Game()
                {
                    Id = 4,
                    IsDeleted = false,
                    Discontinued = false,
                    Key = "W III WH",
                    Name = "The Witcher III: Wild Hunt",
                    Description = "In the past he has raised and overthrown monarchs, battled legendary monsters and saved the lives of many. Now Geralt embarks on his most personal quest to save his loved ones and protect the world from an ancient threat. The story is drawn based on player decisions.Each action will have consequences which change the story and the game world.NPCs, communities, monsters and locations all change, based on player choice.",
                    Price = 44,
                    UnitsInStock = 9,
                    PublisherId = 4
                });
        }
        public static void GameGenreSeed(EntityTypeBuilder<GameGenre> builder)
        {
            builder.HasData(
                new GameGenre()
                {
                    GameId = 1,
                    GenreId = 11
                },
                new GameGenre()
                {
                    GameId = 2,
                    GenreId = 9
                },
                new GameGenre()
                {
                    GameId = 3,
                    GenreId = 14
                },
                new GameGenre()
                {
                    GameId = 4,
                    GenreId = 2
                });
        }
        public static void GamePlatformTypeSeed(EntityTypeBuilder<GamePlatformType> builder)
        {
            builder.HasData(
                new GamePlatformType()
                {
                    GameId = 1,
                    PlatformTypeId = 1
                },
                new GamePlatformType()
                {
                    GameId = 2,
                    PlatformTypeId = 2
                },
                new GamePlatformType()
                {
                    GameId = 3,
                    PlatformTypeId = 3
                },
                new GamePlatformType()
                {
                    GameId = 4,
                    PlatformTypeId = 4
                });
        }
        public static void CommentSeed(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment()
                {
                    Id = 1,
                    GameId = 1,
                    GameKey = "GTA V",
                    IsDeleted = false,
                    Body = "Nice Game!",
                    Name = "Ivan242"
                },
                new Comment()
                {
                    Id = 2,
                    GameId = 1,
                    GameKey = "GTA V",
                    IsDeleted = false,
                    Body = "Completely agree",
                    Name = "Mike",
                    ParentCommentId = 1
                },
                new Comment()
                {
                    Id = 3,
                    GameId = 1,
                    GameKey = "GTA V",
                    IsDeleted = false,
                    Body = "Agree too",
                    Name = "Denis",
                    ParentCommentId = 1
                },
                new Comment()
                {
                    Id = 4,
                    GameId = 1,
                    GameKey = "GTA V",
                    IsDeleted = false,
                    Body = "You are right!",
                    Name = "Alissa",
                    ParentCommentId = 2
                },
                new Comment()
                {
                    Id = 5,
                    GameId = 1,
                    IsDeleted = false,
                    Body = "It could be better",
                    Name = "Nikolay T"
                });
        }

        public static void PublisherSeed(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(
                new Publisher
                {
                    Id = 1,
                    CompanyName = "EA",
                    Description = "Electronic Arts",
                    HomePage = "www.ea.com"
                },
                new Publisher
                {
                    Id = 2,
                    CompanyName = "Ubisoft",
                    Description = "Ubisoft Entertainment S.A.",
                    HomePage = "www.ubisoft.com"
                },
                new Publisher
                {
                    Id = 3,
                    CompanyName = "4a Games",
                    Description = "4a Games Ukraine",
                    HomePage = "www.4a-games.com"
                },
                new Publisher
                {
                    Id = 4,
                    CompanyName = "GSC Game World",
                    Description = "GSC Game World",
                    HomePage = "www.gsc-game.com"
                },
                new Publisher
                {
                    Id = 5,
                    CompanyName = "Wargaming",
                    Description = "Wargaming.net",
                    HomePage = "wargaming.com"
                }
            );
        }
    }
}
