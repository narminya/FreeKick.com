using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Abstraction
{
  public  interface IBroadcastRepository
    {
        Task<Comment> CreateMessage(string message, string minute, int gameId);

    }
}
