using CastGroupCourse.Core.CourseAgg.Entities;
using CastGroupCourse.Core.CourseAgg.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IActionResult PostCategory([FromBody] Course NewCourse)
        {
            var result = _courseService.InsertCourse(NewCourse);
            if (result.Success)
            {
                return Created("/Course", result.Object);
            }

            if (result.Message != null)
            {
                return BadRequest(new { error = result.Message });
            }
            return StatusCode(500);
        }       

        [HttpPut("{id}")]
        public IActionResult PutCategory(int id, [FromBody] Course NewCourse)
        {           
            var result = _courseService.UpdateCourse(NewCourse);
            if (result.Success)
            {
                return Created("/Course", result.Object);
            }

            if (result.Message != null)
            {
                return BadRequest(new { error = result.Message });
            }
            return StatusCode(500);
        }

        [HttpDelete("{id}")]
        public void DeleteCategory(int id)
        {
            _courseService.DeleteCourse(id);
        }
    }
}
