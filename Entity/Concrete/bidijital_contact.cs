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
    [Table("bidijital_contact")]
    public class bidijital_contact:IEntity
    {
        [Key]
        public int id { get; set; }
        public string message { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string phone { get; set; }


    }
}
