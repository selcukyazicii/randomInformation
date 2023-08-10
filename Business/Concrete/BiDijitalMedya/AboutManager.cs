using Business.Abstract.BiDijitalMedya;
using DataAccess.Abstract.BiDijitalMedya;
using DataAccess.Concrete.EntityFramework.BiDijitalMedya;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BiDijitalMedya
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
    
        public async Task<List<bidijital_about>> AboutList()
        {
            var list = await _aboutDal.GetAllAsync(true);
            return list.ToList();
        }

        public async Task<bidijital_about> AddAboutUs(bidijital_about about)
        {
            bidijital_about abouts;
            abouts = await _aboutDal.AddAsync(about);
            return abouts;
        }

        public async Task DeleteAbout(int id)
        {
            var result = await _aboutDal.GetAsync(id);
            _aboutDal.Remove(result); ;
        }
    }
}
