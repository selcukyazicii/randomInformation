using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.BiDijitalMedya
{
    public interface IAboutUsService
    {
        Task<bidijital_about_us> AddAboutUs(bidijital_about_us about);
        Task<List<bidijital_about_us>> AboutUsList();
        Task DeleteAboutUs(int id);
    }
}
