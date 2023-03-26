using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager:IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
