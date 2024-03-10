using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DA
{
    public class BooksRepository : IBooksRepository
    {
        List<Books> listBooks = new List<Books>()
        {
            new Books(1, "Angles & Demons"),
            new Books(2, "Fast & Furious"),
            new Books(3, "Life of Pie"),
            new Books(4, "Inferno")
        };
        public List<Books> Get()
        {
          return listBooks.OrderBy(x => x.BookName).ToList();
        }

        public Books Get(int Bookid)
        {
            Books oBooks = listBooks.Where(x => x.BookId == Bookid).FirstOrDefault();
            return oBooks;
        }

        public bool Add(Books model)
        {
            listBooks.Add(model);
            return true;
        }

        public bool Update(Books model)
        {
            bool isExecuted = false;
            Books oBooks = listBooks.Where(x => x.BookId == model.BookId).FirstOrDefault();
            if (oBooks != null)
            {
                listBooks.Remove(oBooks);
                listBooks.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete (int id)
        {
            bool isExecuted = false;
            Books oBooks = listBooks.Where(x => x.BookId == id).FirstOrDefault();
            if (oBooks != null)
            {
                listBooks.Remove(oBooks);
                isExecuted = true;
            }
            return isExecuted;
        }

    }
}
