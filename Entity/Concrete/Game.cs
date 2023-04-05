﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Game:IEntity
    {
        [Key]
        public int id { get; set; }
        public int game_type { get; set; }
        public string content { get; set; }
    }
}