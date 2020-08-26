using CastGroupCourse.Core.CourseAgg.Entities;
using CastGroupCourse.Core.CourseAgg.Interfaces.Repositories;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CastGroupCourse.Infra.Data.Repositories
{
    public class CourseRepositorie : ICourse
    {
        private readonly IDbConnection conexao;
        public CourseRepositorie(IConfiguration conf) => conexao = new SqlConnection("Data Source=localhost,1433;Initial Catalog=CastGroup;Persist Security Info=False;User ID=tmds;Password=tmds;MultipleActiveResultSets=False;");
        public List<Course> GetCourse()
        {
            return this.conexao.Query<Course>("SELECT * FROM Course").ToList();
        }
        public Course GetCourseId(int Id)
        {
            return this.conexao.Query<Course>("SELECT * FROM Course WHERE @Id = Id", new { Id = Id }).SingleOrDefault();
        }
        public void InsertCourse(Course NewCourse)
        {
            this.conexao.Execute(@"INSERT Course(SubjectDescription,StartDate,EndDate,NumberStudents,CategoryId) VALUES (@SubjectDescription,@StartDate,@EndDate,@NumberStudents,@CategoryId)",
            new { SubjectDescription = NewCourse.SubjectDescription, StartDate = NewCourse.StartDate, EndDate= NewCourse.EndDate, NumberStudents= NewCourse.NumberStudents, CategoryId= NewCourse.CategoryId});
        }
        public void DeleteCoursey(int Id)
        {
            this.conexao.Execute(@"DELETE FROM Course WHERE @Id = id", new { Id = Id });
        }
        public void UpdateCourse(Course NewCourse)
        {
            this.conexao.Execute("UPDATE Course SET SubjectDescription=@SubjectDescription,StartDate=@StartDate,EndDate=@EndDate,NumberStudents=@NumberStudents,CategoryId=@CategoryId WHERE Id=" + NewCourse.Id,
           new { SubjectDescription = NewCourse.SubjectDescription, StartDate = NewCourse.StartDate, EndDate = NewCourse.EndDate, NumberStudents = NewCourse.NumberStudents, CategoryId = NewCourse.CategoryId, Id = NewCourse.Id });
        }
    }
}
