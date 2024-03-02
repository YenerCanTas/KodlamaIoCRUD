using DenemeProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.DataAccess.Abstract;

public interface IInstructorDal
{
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(Instructor instructor);

    Instructor Get(Expression<Func<Instructor, bool>> filter);
    List<Instructor> GetList(Expression<Func<Instructor, bool>> filter = null);
    void Delete(int instructorId);
}
