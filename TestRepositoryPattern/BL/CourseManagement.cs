using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepositoryPattern.DA;

namespace TestRepositoryPattern.BL
{
    public class CourseManagement
    {
        ICourseRepository _repository;

        public CourseManagement(ICourseRepository repository)
        {
            _repository = repository;
        }

        public List<Course> Get()
        {
            return _repository.Get();
        }

        public Course Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Course SI)
        {
            return _repository.Add(SI);
        }

        public bool Update(Course SI)
        {
            return _repository.Update(SI);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

    }
}
