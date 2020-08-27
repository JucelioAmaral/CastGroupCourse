using CastGroupCourse.Core.Aggregate.CourseAgg.Entities;
using CastGroupCourse.Core.Aggregate.CourseAgg.Interfaces.Repositories;
using CastGroupCourse.Core.Aggregate.CourseAgg.Interfaces.Services;
using CastGroupCourse.Core.CourseAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastGroupCourse.Core.Aggregate.CourseAgg.Services
{   
        public class CategoryAndCourseService: ICategoryAndCourseService
        {

        private readonly ICategoryAndCourse _categoryAndCourseRepository;
        public CategoryAndCourseService(ICategoryAndCourse category)
        {
            _categoryAndCourseRepository = category;
        }
        public List<CategoryAndCourse> CategoryAndCourse()
        {
            return _categoryAndCourseRepository.CategoryAndCourse();
        }
    }
}
