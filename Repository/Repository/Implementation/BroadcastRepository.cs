using Domain.Entity;
using Repository.DataAccessLayer;
using Repository.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Implementation
{
    public class BroadcastRepository : IBroadcastRepository
    {
        private AppDbContext _context;

        public BroadcastRepository(AppDbContext context) => _context = context;
        public async Task<Comment> CreateMessage(string message, string minute, int gameId)
        {
            var comment = new Comment { Message = message, Minute = minute };
            var gameComment = new GameComment { Comment = comment, GameId = gameId };

            _context.GameComments.Add(gameComment);
            await _context.SaveChangesAsync();
            return comment;
        }
    }
}
