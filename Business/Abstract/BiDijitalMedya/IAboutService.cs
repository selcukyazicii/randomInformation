using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.BiDijitalMedya
{
    public interface IAboutService
    {
        Task<bidijital_about> AddAboutUs(bidijital_about about);
        Task<List<bidijital_about>> AboutList();
        Task DeleteAbout(int id);
    }
}
