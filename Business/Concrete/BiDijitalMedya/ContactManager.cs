using Business.Abstract.BiDijitalMedya;
using DataAccess.Abstract.BiDijitalMedya;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BiDijitalMedya
{
    public class ContactManager:IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal= contactDal;
        }

        public async Task<bidijital_contact> AddContact(bidijital_contact contact)
        {
            bidijital_contact dijital;
            dijital = await _contactDal.AddAsync(contact);
            return dijital;
        }
    }
}
