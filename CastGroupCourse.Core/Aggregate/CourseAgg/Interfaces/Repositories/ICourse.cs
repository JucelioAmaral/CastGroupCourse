using CastGroupCourse.Core.CourseAgg.Entities;
using CastGroupCourse.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastGroupCourse.Core.CourseAgg.Interfaces.Repositories
{
   public interface ICourse
    {
        List<Course> GetCourse();
        Course GetCourseId(int Id);
        void InsertCourse(Course NewCourse);
        void DeleteCoursey(int Id);
        void UpdateCourse(Course NewCourse);
        bool GetCourseValidationDate(Course NewCourse);
    }    
  
}
