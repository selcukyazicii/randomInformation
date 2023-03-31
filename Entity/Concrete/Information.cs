using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Information:IEntity
    {
        [Key]
        public int id { get; set; }
        public string content { get; set; }

    }
}
