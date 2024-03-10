using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryPattern.DA
{
    public interface ICourseRepository
    {
        List<Course> Get();
        Course Get(int id);
        bool Add(Course SI);
        bool Update(Course SI);
        bool Delete(int id);
    }
}
