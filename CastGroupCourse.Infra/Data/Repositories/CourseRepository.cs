﻿using CastGroupCourse.Core.CourseAgg.Entities;
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
    public class CourseRepository : ICourse
    {
        private readonly IDbConnection conexao;
        public CourseRepository(IConfiguration conf) => conexao = new SqlConnection("Server=tcp:castgroupcourse.database.windows.net,1433;Initial Catalog=CastGroupCourse;Persist Security Info=False;User ID=castgroupcourse;Password=rt@110700;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public List<Course> GetCourse()
        {
            return this.conexao.Query<Course>("SELECT E.Id,E.SubjectDescription,E.StartDate,E.EndDate,E.NumberStudents,R.Description as Category FROM dbo.Course E INNER JOIN dbo.Category R ON E.IdCategory = R.Id ").ToList();
        }
        public Course GetCourseId(int Id)
        {
            return this.conexao.Query<Course>("SELECT * FROM Course WHERE @Id = Id", new { Id = Id }).SingleOrDefault();
        }
        public void InsertCourse(Course NewCourse)
        {
            this.conexao.Execute(@"INSERT Course(SubjectDescription,StartDate,EndDate,NumberStudents,IdCategory) VALUES (@SubjectDescription,@StartDate,@EndDate,@NumberStudents,@IdCategory)",
            new { SubjectDescription = NewCourse.SubjectDescription, StartDate = NewCourse.StartDate, EndDate = NewCourse.EndDate, NumberStudents = NewCourse.NumberStudents, NewCourse.IdCategory });
        }
        public void DeleteCoursey(int Id)
        {
            this.conexao.Execute(@"DELETE FROM Course WHERE @Id = id", new { Id = Id });
        }
        public void UpdateCourse(Course NewCourse)
        {
            this.conexao.Execute("UPDATE Course SET SubjectDescription=@SubjectDescription,StartDate=@StartDate,EndDate=@EndDate,NumberStudents=@NumberStudents,IdCategory=@IdCategory WHERE Id=" + NewCourse.Id,
           new { SubjectDescription = NewCourse.SubjectDescription, StartDate = NewCourse.StartDate, EndDate = NewCourse.EndDate, NumberStudents = NewCourse.NumberStudents, IdCategory = NewCourse.IdCategory });
        }
        public bool GetCourseValidationDate(Course NewCourse)
        {
            var rangeDate = this.conexao.Query<Course>("SELECT * FROM Course WHERE StartDate >='" + NewCourse.StartDate + "' AND EndDate <= '" + NewCourse.EndDate + "'").ToList();

            if (rangeDate.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
