using DenemeProje.DataAccess.Abstract;
using DenemeProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.DataAccess.Concrete;

public class InstructorDal:IInstructorDal
{
     
        private static List<Instructor> _instructors;
    public InstructorDal()
    {
        _instructors = new List<Instructor>
            {
            new Instructor { Id = 1, Name = "John Doe" },
            new Instructor { Id = 2, Name = "Jane Smith" },
            new Instructor { Id = 3, Name = "Michael Johnson" }
            };
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }
    public void Update(Instructor instructor)
    {
        Instructor instructorToUpdate = _instructors.FirstOrDefault(i => i.Id == instructor.Id);
        if (instructorToUpdate != null)
        {
            instructorToUpdate.Name = instructor.Name;
        }
    }
    public void Delete(int instructorId)
    {
        Instructor instructorToDelete = _instructors.FirstOrDefault(i => i.Id == instructorId);
        if (instructorToDelete != null)
        {
            _instructors.Remove(instructorToDelete);
        }
    }
    public Instructor Get(Expression<Func<Instructor, bool>> filter)
    {
        return _instructors.SingleOrDefault(filter.Compile());
    }
    public List<Instructor> GetList(Expression<Func<Instructor, bool>> filter)
    {
        if (filter == null)
        {
            return _instructors;
        }
        else
        {
            return _instructors.Where(filter.Compile()).ToList();
        }
    }

    public void Delete(Instructor instructor)
    {
        throw new NotImplementedException();
    }
}





































