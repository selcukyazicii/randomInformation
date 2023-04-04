using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public  class GameType:IEntity
    {
        [Key]
        public int id { get; set; }
        public string game_name { get; set; }
    }
}
