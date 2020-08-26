using CastGroupCourse.Core.CourseAgg.Entities;
using CastGroupCourse.Core.CourseAgg.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastGroupCourse.Controllers{
  
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public List<Course> GetCourses()
        {
            return _courseService.GetCourse();
        }

        [HttpGet("{id}")]
        public Course GetCategoryId(int id)
        {
            return _courseService.GetCourseId(id);
        }

        [HttpPost]
        public void PostCategory([FromBody] Course NewCourse)
        {
            _courseService.InsertCourse(NewCourse);
        }

        [HttpPut("{id}")]
        public void PutCategory(int id, [FromBody] Course NewCourse)
        {
            _courseService.UpdateCourse(NewCourse);
        }

        [HttpDelete("{id}")]
        public void DeleteCategory(int id)
        {
            _courseService.DeleteCourse(id);
        }
    }
}
