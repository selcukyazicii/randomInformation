using Business.Abstract.BiDijitalMedya;
using DataAccess.Abstract.BiDijitalMedya;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BiDijitalMedya
{
    public class AboutUsManager:IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;
        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public async Task<List<bidijital_about_us>> AboutUsList()
        {
            var list = await _aboutUsDal.GetAllAsync();
            return list.ToList();
        }

        public async Task<bidijital_about_us> AddAboutUs(bidijital_about_us about)
        {
            bidijital_about_us about_us;
            about_us = await _aboutUsDal.AddAsync(about);
            return about_us;
        }

        public async Task DeleteAboutUs(int id)
        {
            var result = await _aboutUsDal.GetAsync(id);
            _aboutUsDal.Remove(result);
        }
    }
}
