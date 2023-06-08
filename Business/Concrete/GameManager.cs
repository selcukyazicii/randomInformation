using Business.Abstract;
using Core.Utilties.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business.Concrete
{
    public class GameManager:IGameService
    {
        private readonly IGameDal _gameDal;
        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public IResult AddContent(TruthOrDareVM game)
        {
            Truth games = new Truth();
            games.game_type = 1;
            games.content=game.content;
            _gameDal.Add(games);
            return new SuccessResult("Başarılı");
        }

        public List<Truth> GetAll()
        {
            var result = _gameDal.GetAll();
            return result;
        }

        public Truth GetTruth()
        {
            var countOfTruth=_gameDal.GetAll().Count();
            var random = new Random().Next(1, countOfTruth);
            return _gameDal.Get(x=>x.id==random);
        }
    }
}
