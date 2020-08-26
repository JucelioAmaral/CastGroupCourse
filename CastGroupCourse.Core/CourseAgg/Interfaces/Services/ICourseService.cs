using CastGroupCourse.Core.CourseAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastGroupCourse.Core.CourseAgg.Interfaces.Services
{
   public interface ICourseService
    {
        List<Course> GetCourse();
        Course GetCourseId(int Id);
        void InsertCourse(Course NewCourse);
        void DeleteCourse(int Id);
        void UpdateCourse(Course NewCourse);
    }
}
