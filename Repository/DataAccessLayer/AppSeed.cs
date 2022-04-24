using Domain.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccessLayer
{
    public static class AppSeed
    {
        public static IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                db.Database.Migrate();
                InitPosition(db);
                InitGamePosition(db);
                InitLeague(db);
                InitCountry(db);
                InitSeason(db);
                 InitTeams(db);
                  InitTeamLeague(db);
                  InitNews(db);
                InitTags(db);
                InitPlayer(db);
                  InitNewsTag(db);
                InitGame(db);
                InitGameTeams(db);
                   InitGameLineup(db);
                InitTeamPlayer(db);
            }
            return app;
        }



        private static void InitGamePosition(AppDbContext db)
        {
            if (!db.GamePositions.Any())
            {
                db.GamePositions.AddRange(
                     new GamePosition { Name = "GoalKeeper" },
                     new GamePosition { Name = "Defender" },
                     new GamePosition { Name = "Midfielder" },
                     new GamePosition { Name = "Forward" }
                    );
            }

            db.SaveChanges();
        }
        private static void InitTeamPlayer(AppDbContext db)
        {
            if (!db.TeamPlayer.Any())
            {
                db.TeamPlayer.AddRange(
                    new TeamPlayer { PlayerId = 1, TeamId = 2, Num = 1 },
                    new TeamPlayer { PlayerId = 11, TeamId = 2, Num = 1 },
                    new TeamPlayer { PlayerId = 12, TeamId = 2, Num = 1 },
                    new TeamPlayer { PlayerId = 13, TeamId = 2, Num = 1 },
                    new TeamPlayer { PlayerId = 14, TeamId = 2, Num = 1 },
                    new TeamPlayer { PlayerId = 15, TeamId = 2, Num = 1 },
                    new TeamPlayer { PlayerId = 16, TeamId = 2, Num = 1 },
                    new TeamPlayer { PlayerId = 17, TeamId = 2, Num = 1 },
                    new TeamPlayer { PlayerId = 18, TeamId = 2, Num = 1 },
                    new TeamPlayer { PlayerId = 19, TeamId = 2, Num = 1 },
                    new TeamPlayer { PlayerId = 20, TeamId = 2, Num = 1 },
                    new TeamPlayer { PlayerId = 2, TeamId = 1, Num = 1 },
                    new TeamPlayer { PlayerId = 3, TeamId = 1, Num = 1 },
                    new TeamPlayer { PlayerId = 4, TeamId = 1, Num = 1 },
                    new TeamPlayer { PlayerId = 5, TeamId = 1, Num = 1 },
                    new TeamPlayer { PlayerId = 6, TeamId = 1, Num = 1 },
                    new TeamPlayer { PlayerId = 7, TeamId = 1, Num = 1 },
                    new TeamPlayer { PlayerId = 8, TeamId = 1, Num = 1 },
                    new TeamPlayer { PlayerId = 9, TeamId = 1, Num = 1 },
                    new TeamPlayer { PlayerId = 10, TeamId = 1, Num = 1 },
                    new TeamPlayer { PlayerId = 21, TeamId = 1, Num = 1 },
                    new TeamPlayer { PlayerId = 22, TeamId = 1, Num = 1 }
                    );
            }

            db.SaveChanges();
        }
        private static void InitPlayer(AppDbContext db)
        {
            if (!db.Player.Any())
            {
                db.Player.AddRange(


        new Player { Surname = "Ter Stegen", PositionId = 1 },
        new Player { Surname = "Araujo", PositionId = 2 },
        new Player { Surname = "Pique", PositionId = 2 },
        new Player { Surname = "Alba", PositionId = 2 },
        new Player { Surname = "Garcia", PositionId = 2 },
        new Player { Surname = "Pedri", PositionId = 3 },
        new Player { Surname = "Busquets", PositionId = 3 },
        new Player { Surname = "De Jong", PositionId = 3 },
        new Player { Surname = "Torres", PositionId = 4 },
        new Player { Surname = "Aubameyang", PositionId = 4 },
        new Player { Surname = "Dembele", PositionId = 4 },
        new Player { Surname = "Courtous", PositionId = 1 },
        new Player { Surname = "Militao", PositionId = 2 },
        new Player { Surname = "Alaba", PositionId = 2 },
        new Player { Surname = "Nacho", PositionId = 2 },
        new Player { Surname = "Carvajal", PositionId = 3 },
        new Player { Surname = "Casemiro", PositionId = 3 },
        new Player { Surname = "Kroos", PositionId = 3 },
        new Player { Surname = "Vinisius", PositionId = 4 },
        new Player { Surname = "Modric", PositionId = 3 },
        new Player { Surname = "Valverde", PositionId = 4 },
        new Player { Surname = "Rodrigo", PositionId = 3 }
                    );
            }
            db.SaveChanges();
        }
        private static void InitGameLineup(AppDbContext db)
        {
            if (!db.GameLineup.Any())
            {
                db.GameLineup.AddRange(
                    new GameLineup { GameId = 1, TeamPlayerId = 1, GamePositionId = 4, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 2, GamePositionId = 2, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 3, GamePositionId = 1, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 4, GamePositionId = 2, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 5, GamePositionId = 2, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 6, GamePositionId = 3, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 7, GamePositionId = 3, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 8, GamePositionId = 3, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 9, GamePositionId = 3, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 10, GamePositionId = 4, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 11, GamePositionId = 1, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 12, GamePositionId = 1, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 13, GamePositionId = 1, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 14, GamePositionId = 2, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 15, GamePositionId = 2, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 16, GamePositionId = 2, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 17, GamePositionId = 3, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 18, GamePositionId = 3, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 19, GamePositionId = 3, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 20, GamePositionId = 3, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 21, GamePositionId = 2, Start = true },
                    new GameLineup { GameId = 1, TeamPlayerId = 21, GamePositionId = 1, Start = true }
                    );
            }

            db.SaveChanges();
        }
        private static void InitGame(AppDbContext db)
        {
            if (!db.Games.Any())
            {
                db.Games.AddRange(
              new Game { LeagueId = 3, AwayScore = 4, HomeScore = 0, IsFinished = true, SeasonId = 2, }
                );
            }

            db.SaveChanges();
        }
        private static void InitGameTeams(AppDbContext db)
        {
            if (!db.GamesTeam.Any())
            {
                db.GamesTeam.AddRange(
              new GameTeam { AwayTeamId = 2, HomeTeamId = 1, GameId = 1 }
                );
            }

            db.SaveChanges();
        }
        private static void InitTags(AppDbContext db)
        {
            if (!db.Tags.Any())
            {
                db.Tags.AddRange(new Tag { Name = "Messi" }, new Tag { Name = "Argentina" }, new Tag { Name = "Psg" }, new Tag { Name = "Barcelona" });
            }

            db.SaveChanges();
        }
        private static void InitNewsTag(AppDbContext db)
        {
            if (!db.NewsTag.Any())
            {
                db.NewsTag.AddRange(
                    new NewsTag { NewsId = 1, TagId = 1 }, new NewsTag { NewsId = 1, TagId = 2 }, new NewsTag { NewsId = 1, TagId = 3 },
                    new NewsTag { NewsId = 2, TagId = 1 }, new NewsTag { NewsId = 2, TagId = 2 }, new NewsTag { NewsId = 2, TagId = 3 },
                    new NewsTag { NewsId = 3, TagId = 1 }, new NewsTag { NewsId = 3, TagId = 2 }, new NewsTag { NewsId = 3, TagId = 3 }
                    );
            }

            db.SaveChanges();
        }
        private static void InitNews(AppDbContext db)
        {

            if (!db.News.Any())
            {
                db.News.AddRange(
                    new News { Title = "Messi uncertain on future: After the World Cup I'm going to rethink many things", Description = "he 34-year-old will consider his options after the tournament in Qatar later this year", Image = "messi.jpg" },
                      new News { Title = "Messi uncertain on future: After the World Cup I'm going to rethink many things", Description = "he 34-year-old will consider his options after the tournament in Qatar later this year", Image = "messi.jpg" },
                        new News { Title = "Messi uncertain on future: After the World Cup I'm going to rethink many things", Description = "he 34-year-old will consider his options after the tournament in Qatar later this year", Image = "messi.jpg" }
                    );
            }

            db.SaveChanges();
        }
        private static void InitTeamLeague(AppDbContext db)
        {
            if (!db.TeamLeague.Any())
            {
                db.TeamLeague.AddRange(
                    new TeamLeague { LeagueId = 3, Points = 56, SeasonId = 2, TeamId = 1 },
                    new TeamLeague { LeagueId = 3, Points = 53, SeasonId = 2, TeamId = 2 },
                    new TeamLeague { LeagueId = 6, Points = 47, SeasonId = 2, TeamId = 8 },
                    new TeamLeague { LeagueId = 6, Points = 74, SeasonId = 2, TeamId = 9 },
                    new TeamLeague { LeagueId = 6, Points = 85, SeasonId = 2, TeamId = 5 },
                    new TeamLeague { LeagueId = 6, Points = 74, SeasonId = 2, TeamId = 6 },
                    new TeamLeague { LeagueId = 6, Points = 85, SeasonId = 2, TeamId = 7 },
                    new TeamLeague { LeagueId = 2, Points = 88, SeasonId = 2, TeamId = 3 },
                    new TeamLeague { LeagueId = 2, Points = 85, SeasonId = 2, TeamId = 4 }

                    );
            }
            db.SaveChanges();
        }
        private static void InitTeams(AppDbContext db)
        {
            if (!db.Teams.Any())
            {
                db.Teams.AddRange(
                         new Team { Name = "Manchester City", CountryId = 1, Coach = "Pep Guardiola", Logo = "mancity.png", Stadium = "Etihad", },
                         new Team { Name = "Manchester United", CountryId = 1, Coach = "Ralph Rangnik", Logo = "mu.png", Stadium = "Old Trafford", TitleImage = "mutitle.png" },
                         new Team { Name = "Liverpool", CountryId = 1, Coach = "Yurgen Klopp", Logo = "liverpool.png", Stadium = "Amfield", TitleImage = "liverpooltitle.jpg" },
                         new Team { Name = "Chelsea", CountryId = 1, Coach = "Tomas Tuchel", Logo = "chelsea.png", Stadium = "Stamford Bridge", TitleImage = "chelseatitle.png" },
                         new Team { Name = "Arsenal", CountryId = 1, Coach = "Mikel Arteta", Logo = "arsenal.png", Stadium = "Emirates", TitleImage = "arsenaltitle.png" },
                         new Team { Name = "Bayern Munich", CountryId = 4, Coach = "Julian Nagelsmann", Logo = "bayern.png", Stadium = "Allianz Arena", TitleImage = "bayerntitle.png" },
                         new Team { Name = "Borussia Dortmund", CountryId = 4, Coach = "Marco Rose", Logo = "dortmund.png", Stadium = "Signal Iduna Park", TitleImage = "dortmundtitle.png" },
                         new Team { Name = "Barcelona", CountryId = 6, Coach = "Xavi Hernandes", Logo = "barcelona.png", Stadium = "Camp Nou", TitleImage = "barcatitle.png" },
                         new Team { Name = "Real Madrid", CountryId = 6, Coach = "Ancelotti", Logo = "real_madrid.png", Stadium = "Santiago Bernabeu", TitleImage = "realtitle.jpg" },
                         new Team { Name = "Napoli", CountryId = 1, Coach = "Pep Guardiola", Logo = "napoli.png", Stadium = "Etihad", },
                         new Team { Name = "Juventus", CountryId = 1, Coach = "Massimiliano Allegri", Logo = "juventus.png", Stadium = "Allianz Stadium", }

                    );
            }

            db.SaveChanges();
        }
        private static void InitLeague(AppDbContext db)
        {
            if (!db.League.Any())
            {
                db.League.AddRange(
                         new League { Name = "English Premier League" },
                         new League { Name = "Eredevise" },
                         new League { Name = "Seria A" },
                         new League { Name = "Laliga" },
                         new League { Name = "Bundesliga" },
                         new League { Name = "Liga 1" }
                    );
            }

            db.SaveChanges();
        }
        private static void InitSeason(AppDbContext db)
        {
            if (!db.Seasons.Any())
            {
                db.Seasons.AddRange(
                     new Season { Name = "2021/2022" },
                     new Season { Name = "2020/2021" }
                    );
            }

            db.SaveChanges();
        }
        private static void InitPosition(AppDbContext db)
        {
            if (!db.Positions.Any())
            {
                db.Positions.AddRange(
                     new Position { Name = "GoalKeeper" },
                     new Position { Name = "Defender" },
                     new Position { Name = "Midfielder" },
                     new Position { Name = "Forward" },
                     new Position { Name = "Playmaker" },
                     new Position { Name = "Winger" }
                    );
            }

            db.SaveChanges();
        }
        private static void InitCountry(AppDbContext db)
        {
            if (!db.Country.Any())
            {
                db.Country.AddRange(
                     new Country { Name = "Spain" },
                     new Country { Name = "Italy" },
                     new Country { Name = "Germany" },
                     new Country { Name = "France" },
                     new Country { Name = "Netherland" },
                     new Country { Name = "England" },
                     new Country { Name = "Argentina" },
                     new Country { Name = "Brazil" },
                     new Country { Name = "Portugal" },
                     new Country { Name = "Uruguay" }
                    );
            }

            db.SaveChanges();
        }
    }
}
