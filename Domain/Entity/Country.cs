﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
