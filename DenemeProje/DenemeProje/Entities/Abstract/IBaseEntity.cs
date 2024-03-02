using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.Entities.Abstract;

public interface IBaseEntity
{
    public string Name { get; set; }
    public int Id { get; set; }
}
