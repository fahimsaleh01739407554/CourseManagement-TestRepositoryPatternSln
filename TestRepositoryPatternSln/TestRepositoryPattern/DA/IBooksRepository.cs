using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DA
{
    public interface IBooksRepository
    {
        List<Books> Get();
        Books Get(int id);
        bool Add(Books model);
        bool Update(Books model);
        bool Delete(int Bookid);
    }
}
