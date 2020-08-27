using CastGroupCourse.Core.CourseAgg.Entities;
using CastGroupCourse.Core.CourseAgg.Interfaces.Repositories;
using CastGroupCourse.Core.CourseAgg.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastGroupCourse.Core.CourseAgg.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourse _courseRepositorie;
        public CourseService(ICourse course)
        {
            _courseRepositorie = course;
        }
        public List<Course> GetCourse()
        {
            return _courseRepositorie.GetCourse();
        }

        public Course GetCourseId(int Id)
        {
            return _courseRepositorie.GetCourseId(Id);
        }

        public void InsertCourse(Course NewCourse)
        {
            _courseRepositorie.InsertCourse(NewCourse);
        }
        public void DeleteCourse(int Id)
        {
            _courseRepositorie.DeleteCoursey(Id);
        }
        public void UpdateCourse(Course NewCourse)
        {
            _courseRepositorie.UpdateCourse(NewCourse);
        }
    }
}
