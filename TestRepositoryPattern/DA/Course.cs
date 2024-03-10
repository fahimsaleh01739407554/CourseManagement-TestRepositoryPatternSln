using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DA
{
    public class Course
    {
        public int Id;
        public string Name;
        public string Trainer;
        public Course()
        {
        }
        public Course(int id, string name, string trainer)
        {
            Id = id;
            Name = name;
            Trainer = trainer;
        }
    }
}
