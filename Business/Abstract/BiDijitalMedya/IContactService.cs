using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.BiDijitalMedya
{
    public interface IContactService
    {
        Task<bidijital_contact> AddContact(bidijital_contact contact);
    }
}
