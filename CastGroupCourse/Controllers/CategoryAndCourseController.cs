using CastGroupCourse.Core.Aggregate.CourseAgg.Entities;
using CastGroupCourse.Core.Aggregate.CourseAgg.Interfaces.Services;
using CastGroupCourse.Core.CourseAgg.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastGroupCourse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryAndCourseController
    {
        private readonly ICategoryAndCourseService _categoryAndCourseService;
        public CategoryAndCourseController(ICategoryAndCourseService categoryAndCourseService)
        {
            _categoryAndCourseService = categoryAndCourseService;
        }
        [HttpGet]
        public List<CategoryAndCourse> GetCategories()
        {
            return _categoryAndCourseService.CategoryAndCourse();
        }
    }
}
