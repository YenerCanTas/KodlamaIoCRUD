using DenemeProje.DataAccess.Abstract;
using DenemeProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje.DataAccess.Concrete;

public class CategoryDal : ICategoryDal
{
    private static List<Category> _categories;

    public CategoryDal()
    {
        _categories = new List<Category>();
        {
            new Category { Id = 1, Name = "Programming" };
            new Category { Id = 2, Name = "Data Science" };
        };
    }
    
    public List<Category> GettAll()
    {
        return _categories;
    }

    public Category GetById(int id)
    {
        return _categories.FirstOrDefault(c => c.Id == id);
    }
    
    
    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(Category categoryId, int id)
    {
        Category categoryToDelete = _categories.FirstOrDefault(c => c.Id == id);
        if (categoryToDelete != null)
        {
            _categories.Remove(categoryToDelete);
        }
    }

    public Category Get(Expression<Func<Category, bool>> filter)
    {
        if (filter == null)
        {
            // Eğer filtre null ise, hata fırlat
            throw new ArgumentNullException(nameof(filter), "Filtre boş olamaz");
        }
        else
        {
            // Filter kullanıcı tarafından belirtilmişse, uygun kategoriyi döndür
            return _categories.SingleOrDefault(filter.Compile());
        }
    }

    public List<Category> GetList(Expression<Func<Category, bool>> filter)
    {
        if (filter == null)
        {
            return _categories;
        }
        else
        {
            return _categories.Where(filter.Compile()).ToList();
        }
    }

    public void Update(Category category)
    {
        Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id == category.Id);
        if (categoryToUpdate != null)
        {
            categoryToUpdate.Name = category.Name;
        }
    }

    internal List<Category>? GetAll()
    {
        throw new NotImplementedException();
    }

    public void Delete(int categoryId)
    {
        throw new NotImplementedException();
    }

    public void Delete(Category categoryId)
    {
        throw new NotImplementedException();
    }
}
