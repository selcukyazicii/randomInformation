using Business.Abstract;
using Core.Utilties.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Game2Manager : IGame2Service
    {
        private readonly IGame2Dal _game2Dal;
        public Game2Manager(IGame2Dal game2Dal)
        {
            _game2Dal = game2Dal;
        }

        public IResult AddContents(TruthOrDareVM game)
        {
            Game2 game2 = new Game2();
            game2.game_type = 1;
            game2.content2 = game.content2;
            _game2Dal.Add(game2);
            return new SuccessResult("Başarılı");
        }

        public List<Game2> GetAll()
        {
            var result = _game2Dal.GetAll();
            return result;
        }

        public Game2 GetDare()
        {
            var countOfDare = _game2Dal.GetAll().Count();
            var random = new Random().Next(1, countOfDare);
            return _game2Dal.Get(x => x.id == random);
        }
    }
}
