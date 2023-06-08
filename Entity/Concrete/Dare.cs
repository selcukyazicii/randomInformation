using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("Games2")]
    public class Dare:IEntity
    {
        [Key]
        public int id { get; set; }
        public int game_type { get; set; }
        public string content2 { get; set; }

    }
}
