using DenemeProje.Business.Abstract;
using DenemeProje.DataAccess.Abstract;
using DenemeProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.Business.Concrete;

public class InstructorManager:IInstructorService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public List<Instructor> GetList()
    {
        return _instructorDal.GetList();
    }

    public Instructor Get(int id)
    {
        return _instructorDal.Get(i => i.Id == id);
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }

    public void Delete(int instructorId)
    {
        _instructorDal.Delete(instructorId);
    }

    public void Delete(Instructor instructorId)
    {
        throw new NotImplementedException();
    }
}


