using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class GoalDto
    {
        public string Player { get; set; }
        public string Minute { get; set; }
        public bool OwnGoal { get; set; }
    }
}
