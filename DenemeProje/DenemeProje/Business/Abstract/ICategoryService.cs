using DenemeProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.Business.Abstract;

public interface ICategoryService
{
    void Add(Category category);
    void Update(Category category);
    void Delete(Category category);
    
    Category Get(int categoryId);
    List<Category> GetList();
    void Delete(int categoryIdToDelete);
}
