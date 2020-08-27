using CastGroupCourse.Core.CourseAgg.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastGroupCourse.Core.Aggregate.CourseAgg.Entities
{
    public class CategoryAndCourse
    {
        [FromQuery(Name = "Id")]     
        public int Id { get; set; }
        [FromQuery(Name = "Description")]      
        public string Description { get; set; }
        public List<Course> Courses { get; set; }
    }
}
