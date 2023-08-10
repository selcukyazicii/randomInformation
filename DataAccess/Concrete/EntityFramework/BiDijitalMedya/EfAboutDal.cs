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
    public class EfAboutDal: EfEntityRepositoryBase<bidijital_about, InformationContext>, IAboutDal
    {
    }
}
