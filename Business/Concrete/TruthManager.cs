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
    public class TruthManager:ITruthService
    {
        private readonly ITruthDal _gameDal;
        public TruthManager(ITruthDal gameDal)
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
        List<int> selectedNumbers = new List<int>();
        public Truth GetTruth()
        {
            var idList = _gameDal.GetAll().Select(s => s.id);
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
            return _gameDal.Get(x => x.id == uniqueRandom);

            
        }
    }
}
