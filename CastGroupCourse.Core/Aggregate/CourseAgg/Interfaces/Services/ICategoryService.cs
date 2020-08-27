using CastGroupCourse.Core.CourseAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastGroupCourse.Core.CourseAgg.Interfaces.Services
{
    public interface ICategoryService
    {
        List<Category> GetCategory();
        Category GetCategoryId(int Id);
        void InsertCategory(Category Description);
        void DeleteCategory(int Id);
        void UpdateCategory(Category Description);
    }
}
