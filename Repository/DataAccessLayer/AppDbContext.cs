using Domain.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccessLayer
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        {

        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameComment> GameComments { get; set; }
        public DbSet<GameLineup> GameLineup { get; set; }
        public DbSet<GamePlayerEvent> GamePlayerEvents { get; set; }
        public DbSet<GamePosition> GamePositions { get; set; }
        public DbSet<GameResult> GameResults { get; set; }
        public DbSet<GameScore> GameScores { get; set; }
        public DbSet<GameTeam> GamesTeam { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupTeam> GroupTeams { get; set; }
        public DbSet<League> League { get; set; }
        public DbSet<Navigation> Navigation { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsTag> NewsTag { get; set; }
        public DbSet<OuterLeague> OuterLeagues { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamLeague> TeamLeague { get; set; }
        public DbSet<TeamPlayer> TeamPlayer { get; set; }
        




    }
}
