using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class Player : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Picture { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<TeamPlayer> Teams { get; set; }
    }
}
