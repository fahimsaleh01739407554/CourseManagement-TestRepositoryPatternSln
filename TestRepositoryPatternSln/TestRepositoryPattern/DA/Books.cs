using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DA
{
    public class Books
    {
        public int BookId;
        public string BookName;
        
        public Books()
        {
        }
        public Books(int id, string name)
        {
            BookId = id;
            BookName = name;
           
        }
    }
}
