using DenemeProje.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.Entities.Concrete;

public class Course:IBaseEntity
{
    
    public string Description { get; set; }
    public int InstructorId { get; set; }
    public int CategoryId { get; set; }
    public string ImageUrl { get; set; }
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
