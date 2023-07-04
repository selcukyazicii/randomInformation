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
    public class DareManager : IDareService
    {
        private readonly IDareDal _game2Dal;
        public DareManager(IDareDal game2Dal)
        {
            _game2Dal = game2Dal;
        }

        public IResult AddContents(TruthOrDareVM game)
        {
            Dare game2 = new Dare();
            game2.game_type = 1;
            game2.content2 = game.content2;
            _game2Dal.Add(game2);
            return new SuccessResult("Başarılı");
        }

        public List<Dare> GetAll()
        {
            var result = _game2Dal.GetAll();
            return result;
        }
        List<int> selectedNumbers = new List<int>();

        public Dare GetDare()
        {
            var idList = _game2Dal.GetAll().Select(s => s.id);
            var countOfTruth = idList.Max() + 1;
            var random = new Random();
            var uniqueRandom = random.Next(1, countOfTruth);

            while (selectedNumbers.Contains(uniqueRandom))
            {
                uniqueRandom = random.Next(1, countOfTruth);
                if (selectedNumbers.Count() == idList.Count())
                {
                    selectedNumbers.Clear();
                }
            }
            selectedNumbers.Add(uniqueRandom);
            return _game2Dal.Get(x => x.id == uniqueRandom);


        }
    }
}
