using Domain.Constants;
using Domain.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.DataAccessLayer
{
    public static class AppSeed
    {
        public async static Task<IApplicationBuilder> Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                var role = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

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
                // InitGameLineup(db);
                InitTeamPlayer(db);
                InitOuter(db);
                InitGroups(db);
                InitGroupTeam(db);
                await InitRoles(db, role);
                InitHeader(db);
                InitStatus(db);
                InitEvent(db);
                InitGameEvent(db);
                InitGameResult(db);

            }
            return app;
        }

        private static void InitGameResult(AppDbContext db)
        {
            if (!db.GameResults.Any())
            {
                db.GameResults.AddRange(new GameResult { Name = "Win", Points = 3, Letter = 'W' },
                    new GameResult { Name = "Draw", Points = 1, Letter = 'D' },
                    new GameResult { Name = "Lose", Points = 0, Letter = 'L' });
            }
            db.SaveChanges();
        }

        private static void InitGameEvent(AppDbContext db)
        {
            //if (!db.GamePlayerEvents.Any())
            //{
            //    db.GamePlayerEvents.AddRange(new GamePlayerEvent { },
            //        new GamePlayerEvent {},
            //        new GamePlayerEvent {});
            //}
            //db.SaveChanges();
        }

        private static void InitEvent(AppDbContext db)
        {
            if (!db.Events.Any())
            {
                db.Events.AddRange(
                    new Event { Name = EventConstant.Goal, Logo = "ball.png" },
                    new Event { Name = EventConstant.Substitution, Logo = "change.png" },
                    new Event { Name = EventConstant.Yellow, Logo = "yc.png" },
                    new Event { Name = EventConstant.YellowRed, Logo = "ywc.png" },
                    new Event { Name = EventConstant.Red, Logo = "rc.png" });
            }
            db.SaveChanges();
        }

        private static void InitStatus(AppDbContext db)
        {
            if (!db.Status.Any())
            {
                db.Status.AddRange(
                    new Status { Name = StatusConstant.Start },
                    new Status { Name = StatusConstant.Bench },
                    new Status { Name = StatusConstant.Change });
            }
            db.SaveChanges();
        }
        private static void InitHeader(AppDbContext db)
        {
            if (!db.Navigation.Any())
            {

                db.Navigation.AddRange(
                    new Navigation { Name = "Breaking", Order = 1, Controller = "Home", Action = "Index" },
                    new Navigation { Name = "Live Scores", Order = 2, Controller = "Match", Action = "LiveScores" },
                    new Navigation { Name = "European Football", Order = 3 },
                    new Navigation { Name = "Champions League", Order = 4 },
                    new Navigation { Name = "Premier League", Order = 5 },

                    new Navigation { Name = "Groups", Order = 1, ParentId = 5, Controller = "OuterLeague", Action = "Index", RouteId = 3 },

                    new Navigation { Name = "Laliga", Order = 1, },
                     new Navigation { Name = "Seria A", Order = 2, },
                     new Navigation { Name = "Laliga", Order = 1, },
                   new Navigation { Name = "Matches", Order = 2, },
                 new Navigation { Name = "Matches", Order = 2, },
                   new Navigation { Name = "Matches", Order = 2 },
                   new Navigation { Name = "Table", Order = 1, },
                 new Navigation { Name = "Table", Order = 1, },
                   new Navigation { Name = "Table", Order = 1 },
                              new Navigation { Name = "FC Barcelona", Order = 1, Controller = "Team", Action = "Index", Image = "/assets/img/teams/barcelona.png" },
                              new Navigation { Name = "Real Madrid", Order = 2, Controller = "Team", Action = "Index", Image = "/assets/img/teams/real_madrid.png" },

                 new Navigation { Name = "Juventus", Order = 1, Controller = "Team", Action = "Index", Image = "/assets/img/teams/juventus.png" },
                   new Navigation { Name = "Napoli", Order = 2, Controller = "Team", Action = "Index", Image = "/assets/img/teams/napoli.png" },
                         new Navigation { Name = "Juventus", Order = 1, Controller = "Team", Action = "Index", Image = "/assets/img/teams/bayern" },
                   new Navigation { Name = "Napoli", Order = 2, Controller = "Team", Action = "Index", Image = "/assets/img/teams/dortmund.png" }
                    );

            }
            db.SaveChanges();
        }
        private static async Task InitRoles(AppDbContext db, RoleManager<IdentityRole> role)
        {
            if (!db.Roles.Any())
            {
                await role.CreateAsync(new IdentityRole { Name = RoleConstants.Admin });
                await role.CreateAsync(new IdentityRole { Name = RoleConstants.User });
                await role.CreateAsync(new IdentityRole { Name = RoleConstants.Moderator });
                await role.CreateAsync(new IdentityRole { Name = RoleConstants.User });
            }
            await db.SaveChangesAsync();
        }
        private static void InitGroupTeam(AppDbContext db)
        {
            if (!db.GroupTeams.Any())
            {
                db.GroupTeams.AddRange(
                    new GroupTeam { GroupId = 1, TeamId = 1, Points = 12 },
                    new GroupTeam { GroupId = 1, TeamId = 2, Points = 11 },
                    new GroupTeam { GroupId = 1, TeamId = 3, Points = 7 },
                    new GroupTeam { GroupId = 1, TeamId = 4, Points = 4 });
            }
            db.SaveChanges();
        }
        private static void InitGroups(AppDbContext db)
        {
            if (!db.Groups.Any())
            {
                db.Groups.AddRange(
                    new Group { OuterLeagueId = 1, Letter = 'A' },
                    new Group { OuterLeagueId = 1, Letter = 'B' },
                    new Group { OuterLeagueId = 1, Letter = 'C' },
                    new Group { OuterLeagueId = 1, Letter = 'D' },
                    new Group { OuterLeagueId = 1, Letter = 'E' },
                    new Group { OuterLeagueId = 1, Letter = 'F' },
                    new Group { OuterLeagueId = 1, Letter = 'G' },
                    new Group { OuterLeagueId = 1, Letter = 'H' },
                    new Group { OuterLeagueId = 2, Letter = 'A' },
                    new Group { OuterLeagueId = 2, Letter = 'B' },
                    new Group { OuterLeagueId = 2, Letter = 'C' },
                    new Group { OuterLeagueId = 2, Letter = 'D' },
                    new Group { OuterLeagueId = 2, Letter = 'E' },
                    new Group { OuterLeagueId = 2, Letter = 'F' },
                    new Group { OuterLeagueId = 2, Letter = 'G' },
                    new Group { OuterLeagueId = 2, Letter = 'H' },
                    new Group { OuterLeagueId = 3, Letter = 'A' },
                    new Group { OuterLeagueId = 3, Letter = 'B' },
                    new Group { OuterLeagueId = 3, Letter = 'C' },
                    new Group { OuterLeagueId = 3, Letter = 'D' },
                    new Group { OuterLeagueId = 3, Letter = 'E' },
                    new Group { OuterLeagueId = 3, Letter = 'F' },
                    new Group { OuterLeagueId = 3, Letter = 'G' },
                    new Group { OuterLeagueId = 3, Letter = 'H' }

                    );
            }

            db.SaveChanges();
        }
        private static void InitOuter(AppDbContext db)
        {
            if (!db.OuterLeagues.Any())
            {
                db.OuterLeagues.AddRange(
                    new OuterLeague { Name = "UEFA Champions League", Title = "lctitle.jpeg", Logo = "lclogo.png" },
                    new OuterLeague { Name = "UEFA Europe League", Title = "letitle.jpeg", Logo = "lelogo.png" },
                    new OuterLeague { Name = "UEFA Conference League", Logo = "conferencelogo.png" }
                    );
            }

            db.SaveChanges();
        }
        private static void InitGamePosition(AppDbContext db)
        {
            if (!db.GamePositions.Any())
            {
                db.GamePositions.AddRange(
                     new GamePosition { Name = "GoalKeeper", CommonName = "Keeper", ShortName = "GK" },
                     new GamePosition { Name = "Striker", CommonName = "Forward", ShortName = "S" },
                     new GamePosition { Name = "Center Defender", CommonName = "Defender", ShortName = "CD" },
                     new GamePosition { Name = "Right Back", CommonName = "Defender", ShortName = "RB" },
                     new GamePosition { Name = "Left Back", CommonName = "Defender", ShortName = "LB" },
                     new GamePosition { Name = "Left CentreBack", CommonName = "Defender", ShortName = "LCB" },
                     new GamePosition { Name = "Right CentreBack", CommonName = "Defender", ShortName = "RCB" },
                     new GamePosition { Name = "Defensive MidFielder", CommonName = "Midfielder", ShortName = "DM" },
                     new GamePosition { Name = "Right MidFielder", CommonName = "Midfielder", ShortName = "RM" },
                     new GamePosition { Name = "Left MidFielder", CommonName = "Midfielder", ShortName = "LM" },
                     new GamePosition { Name = "Left Winger", CommonName = "Forward", ShortName = "LW" },
                     new GamePosition { Name = "Right Winger", CommonName = "Forward", ShortName = "RW" },
                     new GamePosition { Name = "Center Forward", CommonName = "Forward", ShortName = "CF" }
                    );
            }

            db.SaveChanges();
        }
        private static void InitTeamPlayer(AppDbContext db)
        {
            if (!db.TeamPlayer.Any())
            {
                db.TeamPlayer.AddRange(
                    new TeamPlayer { PlayerId = 1, TeamId = 2, Num = 1, PositionId = 1 },
                    new TeamPlayer { PlayerId = 11, TeamId = 2, Num = 1, PositionId = 2 },
                    new TeamPlayer { PlayerId = 12, TeamId = 2, Num = 1, PositionId = 2 },
                    new TeamPlayer { PlayerId = 13, TeamId = 2, Num = 1, PositionId = 2 },
                    new TeamPlayer { PlayerId = 14, TeamId = 2, Num = 1, PositionId = 2 },
                    new TeamPlayer { PlayerId = 15, TeamId = 2, Num = 1, PositionId = 3 },
                    new TeamPlayer { PlayerId = 16, TeamId = 2, Num = 1, PositionId = 3 },
                    new TeamPlayer { PlayerId = 17, TeamId = 2, Num = 1, PositionId = 3 },
                    new TeamPlayer { PlayerId = 18, TeamId = 2, Num = 1, PositionId = 4 },
                    new TeamPlayer { PlayerId = 19, TeamId = 2, Num = 1, PositionId = 4 },
                    new TeamPlayer { PlayerId = 20, TeamId = 2, Num = 1, PositionId = 4 },
                    new TeamPlayer { PlayerId = 2, TeamId = 1, Num = 1, PositionId = 1 },
                    new TeamPlayer { PlayerId = 3, TeamId = 1, Num = 1, PositionId = 2 },
                    new TeamPlayer { PlayerId = 4, TeamId = 1, Num = 1, PositionId = 2 },
                    new TeamPlayer { PlayerId = 5, TeamId = 1, Num = 1, PositionId = 2 },
                    new TeamPlayer { PlayerId = 6, TeamId = 1, Num = 1, PositionId = 3 },
                    new TeamPlayer { PlayerId = 7, TeamId = 1, Num = 1, PositionId = 3 },
                    new TeamPlayer { PlayerId = 8, TeamId = 1, Num = 1, PositionId = 3 },
                    new TeamPlayer { PlayerId = 9, TeamId = 1, Num = 1, PositionId = 4 },
                    new TeamPlayer { PlayerId = 10, TeamId = 1, Num = 1, PositionId = 3 },
                    new TeamPlayer { PlayerId = 21, TeamId = 1, Num = 1, PositionId = 4 },
                    new TeamPlayer { PlayerId = 22, TeamId = 1, Num = 1, PositionId = 3 }
                    );
            }

            db.SaveChanges();
        }
        private static void InitPlayer(AppDbContext db)
        {
            if (!db.Player.Any())
            {
                db.Player.AddRange(


        new Player { Surname = "Ter Stegen", },
        new Player { Surname = "Araujo", },
        new Player { Surname = "Pique", },
        new Player { Surname = "Alba", },
        new Player { Surname = "Garcia", },
        new Player { Surname = "Pedri", },
        new Player { Surname = "Busquets", },
        new Player { Surname = "De Jong", },
        new Player { Surname = "Torres", },
        new Player { Surname = "Aubameyang", },
        new Player { Surname = "Dembele", },
        new Player { Surname = "Courtous", },
        new Player { Surname = "Militao", },
        new Player { Surname = "Alaba", },
        new Player { Surname = "Nacho", },
        new Player { Surname = "Carvajal", },
        new Player { Surname = "Casemiro", },
        new Player { Surname = "Kroos", },
        new Player { Surname = "Vinisius", },
        new Player { Surname = "Modric", },
        new Player { Surname = "Valverde", },
        new Player { Surname = "Rodrigo", }
                    );
            }
            db.SaveChanges();
        }
        private static void InitGameLineup(AppDbContext db)
        {
            if (!db.GameLineup.Any())
            {
                db.GameLineup.AddRange(
                    new GameLineup { GameId = 1, TeamPlayerId = 1, GamePositionId = 4, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 2, GamePositionId = 2, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 3, GamePositionId = 1, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 4, GamePositionId = 2, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 5, GamePositionId = 2, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 6, GamePositionId = 3, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 7, GamePositionId = 3, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 8, GamePositionId = 3, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 9, GamePositionId = 3, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 10, GamePositionId = 4, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 11, GamePositionId = 1, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 12, GamePositionId = 1, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 13, GamePositionId = 1, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 14, GamePositionId = 2, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 15, GamePositionId = 2, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 16, GamePositionId = 2, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 17, GamePositionId = 3, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 18, GamePositionId = 3, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 19, GamePositionId = 3, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 20, GamePositionId = 3, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 21, GamePositionId = 2, StatusId = 2 },
                    new GameLineup { GameId = 1, TeamPlayerId = 21, GamePositionId = 1, StatusId = 2 }
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
                         new Team { Name = "Manchester City", CountryId = 1, Coach = "Pep Guardiola", Logo = "mancity.png", Stadium = "Etihad", TitleImage = "mctitle.jpg" },
                         new Team { Name = "Manchester United", CountryId = 1, Coach = "Ralph Rangnik", Logo = "mu.png", Stadium = "Old Trafford", TitleImage = "mutitle.jpg" },
                         new Team { Name = "Liverpool", CountryId = 1, Coach = "Yurgen Klopp", Logo = "liverpool.png", Stadium = "Amfield", TitleImage = "liverpooltitle.jpg" },
                         new Team { Name = "Chelsea", CountryId = 1, Coach = "Tomas Tuchel", Logo = "chelsea.png", Stadium = "Stamford Bridge", TitleImage = "chelseatitle.jpg" },
                         new Team { Name = "Arsenal", CountryId = 1, Coach = "Mikel Arteta", Logo = "arsenal.png", Stadium = "Emirates", TitleImage = "arsenaltitle.jpg" },
                         new Team { Name = "Bayern Munich", CountryId = 4, Coach = "Julian Nagelsmann", Logo = "bayern.png", Stadium = "Allianz Arena", TitleImage = "bayerntitle.jpg" },
                         new Team { Name = "Borussia Dortmund", CountryId = 4, Coach = "Marco Rose", Logo = "dortmund.png", Stadium = "Signal Iduna Park", TitleImage = "dortmundtitle.jpg" },
                         new Team { Name = "Barcelona", CountryId = 6, Coach = "Xavi Hernandes", Logo = "barcelona.png", Stadium = "Camp Nou", TitleImage = "barcatitle.jpg" },
                         new Team { Name = "Real Madrid", CountryId = 6, Coach = "Ancelotti", Logo = "real_madrid.png", Stadium = "Santiago Bernabeu", TitleImage = "realtitle.jpg" },
                         new Team { Name = "Napoli", CountryId = 1, Coach = "Pep Guardiola", Logo = "napoli.png", Stadium = "Etihad", TitleImage = "napolititle.jpg" },
                         new Team { Name = "Juventus", CountryId = 1, Coach = "Massimiliano Allegri", Logo = "juventus.png", Stadium = "Allianz Stadium", TitleImage = "juventustitle.jpg" }

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
                     new Position { Name = "Forward" }
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
