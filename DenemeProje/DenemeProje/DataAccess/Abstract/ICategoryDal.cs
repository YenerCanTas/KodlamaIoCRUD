using DenemeProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.DataAccess.Abstract;

public interface ICategoryDal
{
    void Add(Category category);
    void Update(Category category);
    void Delete(Category categoryId);
    Category Get(Expression<Func<Category, bool>> filter);
    List<Category> GetList(Expression<Func<Category, bool>> filter =null);
    void Delete(int categoryId);
}
