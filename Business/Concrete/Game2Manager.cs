using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
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
