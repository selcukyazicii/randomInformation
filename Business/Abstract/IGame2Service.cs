using Core.Utilties.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGame2Service
    {
        Game2 GetDare();
        List<Game2> GetAll();
        IResult AddContents(Game2 game);

    }
}
