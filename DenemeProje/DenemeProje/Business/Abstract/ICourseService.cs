using DenemeProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.Business.Abstract;

public interface ICourseService
{
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
    Course Get(int courseId);
    List<Course> GetList();

    List<Course> GetListByInstructor(int instructorId);
    List<Course> GetListByCategory(int categoryId);
    void Delete(int courseIdToDelete);
}
