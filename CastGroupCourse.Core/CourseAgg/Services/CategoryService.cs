using CastGroupCourse.Core.CourseAgg.Entities;
using CastGroupCourse.Core.CourseAgg.Interfaces.Repositories;
using CastGroupCourse.Core.CourseAgg.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastGroupCourse.Core.CourseAgg.Service
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategory _categoryRepositorie;
        public CategoryService(ICategory category)
        {
            _categoryRepositorie = category;
        }

        public List<Category> GetCategory()
        {
            return _categoryRepositorie.GetCategory();
        }

        public Category GetCategoryId(int Id)
        {
            return _categoryRepositorie.GetCategoryId(Id);
        }

        public void InsertCategory(Category Description)
        {
             _categoryRepositorie.InsertCategory(Description);
        }
        public void DeleteCategory(int Id)
        {
             _categoryRepositorie.DeleteCategory(Id);
        }
        public void UpdateCategory(Category Description)
        {
             _categoryRepositorie.UpdateCategory(Description);
        }
    }
}
