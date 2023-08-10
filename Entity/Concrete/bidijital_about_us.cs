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
    [Table("bidjital_about_us")]
    public class bidijital_about_us:IEntity
    {
        [Key]
        public int id { get; set; }
        public string question { get; set; }
    }
}
