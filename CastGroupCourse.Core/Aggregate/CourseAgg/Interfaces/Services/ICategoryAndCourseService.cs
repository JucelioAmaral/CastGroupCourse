using CastGroupCourse.Core.Aggregate.CourseAgg.Entities;
using CastGroupCourse.Core.CourseAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastGroupCourse.Core.Aggregate.CourseAgg.Interfaces.Services
{
  public interface ICategoryAndCourseService
    {
        List<CategoryAndCourse> CategoryAndCourse();
    }
}
