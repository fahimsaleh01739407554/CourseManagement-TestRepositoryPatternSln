using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DA
{
    public class CourseRepository : ICourseRepository
    {
        List<Course> listCourse = new List<Course>()
        {
            new Course(1, "C#.NET", "Nishat Sharmeen"),
            new Course(2, "Database Management", "Habibur Rahman"),
            new Course(3, "Web Development with PHP & Laravel", "Azman Ali"),
            new Course(4, "Graphics", "Mazed Ma")
        };
        public List<Course> Get()
        {
          return listCourse.OrderBy(x => x.Name).ToList();
        }

        public Course Get(int id)
        {
            Course course = listCourse.Where(x => x.Id == id).FirstOrDefault();
            return course;
        }

        public bool Add(Course SI)
        {
            listCourse.Add(SI);
            return true;
        }

        public bool Update(Course SI)
        {
            bool isExecuted = false;
            Course s = listCourse.Where(x => x.Id == SI.Id).FirstOrDefault();
            if (s != null)
            {
                listCourse.Remove(s);
                listCourse.Add(SI);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete (int id)
        {
            bool isExecuted = false;
            Course s = listCourse.Where(x => x.Id == id).FirstOrDefault();
            if (s != null)
            {
                listCourse.Remove(s);
                isExecuted = true;
            }
            return isExecuted;
        }

    }
}
