using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepositoryPattern.DA;

namespace TestRepositoryPattern.BL
{
    public class BooksBusiness
    {
        IBooksRepository _repository;

        public BooksBusiness(IBooksRepository repository)
        {
            _repository = repository;
        }

        public List<Books> Get()
        {
            return _repository.Get();
        }

        public Books Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Books model)
        {
            return _repository.Add(model);
        }

        public bool Update(Books model)
        {
            return _repository.Update(model);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

    }
}
