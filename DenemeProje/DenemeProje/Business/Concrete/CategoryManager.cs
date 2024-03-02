using DenemeProje.Business.Abstract;
using DenemeProje.DataAccess.Abstract;
using DenemeProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.Business.Concrete;

public class CategoryManager : ICategoryService
{
       
        ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }

    public void Delete(int categoryId)
    {
        _categoryDal.Delete(categoryId);
    }

    public Category Get(int categoryId)
    {
        return _categoryDal.Get(c => c.Id == categoryId);
    }

    public List<Category> GetList()
    {
        return _categoryDal.GetList().ToList();
    }

    public void Delete(Category category)
    {
        throw new NotImplementedException();
    }
}


