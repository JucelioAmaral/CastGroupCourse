using CastGroupCourse.Core.CourseAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastGroupCourse.Core.CourseAgg.Interfaces.Repositories
{
   public interface ICourse
    {
        List<Course> GetCourse();
        Course GetCourseId(int Id);
        void InsertCourse(Course SubjectDescription, Course StartDate, Course EndDate, Course NumberStudents, Course CategoryId);
        void DeleteCoursey(int Id);
        void UpdateCourse(Course SubjectDescription, Course StartDate, Course EndDate, Course NumberStudents, Course CategoryId);
    }


   
  
}
