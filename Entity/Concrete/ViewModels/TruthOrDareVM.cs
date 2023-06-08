using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ViewModels
{
    public class TruthOrDareVM
    {
        public int id { get; set; }
        public int game_type { get; set; }
        public string? content { get; set; }
        public string? content2 { get; set; }


    }
}
