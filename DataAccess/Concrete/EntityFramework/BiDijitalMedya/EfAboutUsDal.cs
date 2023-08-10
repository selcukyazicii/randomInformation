using Core.DataAccess.EntityFramework;
using DataAccess.Abstract.BiDijitalMedya;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.BiDijitalMedya
{
    public class EfAboutUsDal: EfEntityRepositoryBase<bidijital_about_us, InformationContext>, IAboutUsDal
    {
    }
}
