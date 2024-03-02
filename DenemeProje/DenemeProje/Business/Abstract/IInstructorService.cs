using DenemeProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.Business.Abstract;

public interface IInstructorService
{
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(Instructor instructorId);
    Instructor Get(int instructorId);
    List<Instructor> GetList();
    void Delete(int instructorIdToDelete);
}
