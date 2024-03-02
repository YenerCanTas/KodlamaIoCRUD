using DenemeProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.DataAccess.Abstract;

public interface ICourseDal
{
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course); 

    Course Get(Expression<Func<Course, bool>> filter);
    List<Course> GetList(Expression<Func<Course, bool>> filter = null);
    void Delete(int courseId);
}
