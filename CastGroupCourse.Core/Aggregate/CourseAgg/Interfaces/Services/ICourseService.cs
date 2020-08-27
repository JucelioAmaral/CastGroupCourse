using CastGroupCourse.Core.CourseAgg.Entities;
using CastGroupCourse.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastGroupCourse.Core.CourseAgg.Interfaces.Services
{
    public interface ICourseService
    {
        List<Course> GetCourse();
        Course GetCourseId(int Id);
        ResponseObject<Course> InsertCourse(Course NewCourse);
        void DeleteCourse(int Id);
        ResponseObject<Course> UpdateCourse(Course NewCourse);
    }
}
