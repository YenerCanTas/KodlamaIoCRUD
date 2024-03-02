using DenemeProje.Business.Abstract;
using DenemeProje.DataAccess.Abstract;
using DenemeProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.Business.Concrete;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(int courseId)
    {
        _courseDal.Delete(courseId);
    }
    public void Update(Course course)
    {
        _courseDal.Update(course);
    }

  

    public Course Get(int courseId)
    {
        return _courseDal.Get(c => c.Id == courseId);
    }

    public List<Course> GetList()
    {
        // ICourseDal aracılığıyla GetList metodu çağrılıyor
        return _courseDal.GetList();
    }

    public List<Course> GetListByInstructor(int instructorId)
    {
        return _courseDal.GetList(c => c.InstructorId == instructorId).ToList();
    }

    public List<Course> GetListByCategory(int categoryId)
    {
        return _courseDal.GetList(c => c.CategoryId == categoryId).ToList();
    }

    void ICourseService.Delete(Course course)
    {
        throw new NotImplementedException();
    }
}

