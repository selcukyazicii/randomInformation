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
    [Table("bidijital_about")]
    public class bidijital_about :IEntity
    {
        [Key]
        public int id { get; set; }
        public string question { get; set; }
        public bool state { get; set; }

    }
}
