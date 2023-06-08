using Core.Utilties.Results;
using Entity.Concrete;
using Entity.Concrete.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGameService
    {
        List<Game> GetAll();
        Game GetTruth();
        IResult AddContent(TruthOrDareVM game);


    }
}
