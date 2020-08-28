using CastGroupCourse.Core.CourseAgg.Entities;
using CastGroupCourse.Core.CourseAgg.Interfaces.Services;
using CastGroupCourse.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CastGroupCourse.Tests
{
    public class CourseServiceFake : ICourseService
    {
        private readonly List<Course> _Course;

        public CourseServiceFake()
        {
            _Course = new List<Course>()
            {
                new Course() {
                Id = 1,
                SubjectDescription = "Eng de Software",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(+6),
                NumberStudents = 10,
                IdCategory = 2 }
            };
        }
        public void DeleteCourse(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCourse()
        {
            throw new NotImplementedException();
        }

        public Course GetCourseId(int Id)
        {
            throw new NotImplementedException();
        }

        public ResponseObject<Course> InsertCourse(Course NewCourse)
        {
            _Course.Add(NewCourse);
            return new ResponseObject<Course>(true, "Criado com sucesso!", obj: NewCourse);
        }

        public ResponseObject<Course> UpdateCourse(Course NewCourse)
        {
            throw new NotImplementedException();
        }
    }
}
