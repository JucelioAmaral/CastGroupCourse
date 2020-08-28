using CastGroupCourse.Controllers;
using CastGroupCourse.Core.CourseAgg.Entities;
using CastGroupCourse.Core.CourseAgg.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CastGroupCourse.Tests
{
    public class CourseControllerTest
    {
        CourseController _controller;
        ICourseService _service;

        public CourseControllerTest()
        {
            _service = new CourseServiceFake();
            _controller = new CourseController(_service);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnsCreatedResponse()
        {

            Course testItem = new Course()
            {
                Id = 2,
                SubjectDescription = "ADM",
                StartDate = DateTime.Now.AddMonths(+6),
                EndDate = DateTime.Now.AddMonths(+12),
                NumberStudents = 10,
                IdCategory = 1
            };
            var createdResponse = _controller.PostCourse(testItem);

            Assert.IsType<CreatedAtActionResult>(createdResponse);
        }
    }
}
