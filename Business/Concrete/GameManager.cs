using Business.Abstract;
using Core.Utilties.Results;
using DataAccess.Abstract;
using Entity.Concrete;
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
        private readonly IGame2Dal _game2Dal;
        public GameManager(IGameDal gameDal,IGame2Dal game2Dal)
        {
            _gameDal = gameDal;
            _game2Dal=game2Dal;
            
        }
        public List<Game> GetAll()
        {
            var result = _gameDal.GetAll();
            return result;
        }

        public Game GetTruth()
        {
            var countOfTruth=_gameDal.GetAll().Count();
            var random = new Random().Next(1, countOfTruth);
            return _gameDal.Get(x=>x.id==random);
        }
    }
}
