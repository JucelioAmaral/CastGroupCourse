using CastGroupCourse.Core.CourseAgg.Entities;
using CastGroupCourse.Core.CourseAgg.Interfaces.Repositories;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Slapper;


namespace CastGroupCourse.Infra.Data.Repositories
{
    public class CategoryRepositorie : ICategory
    {
        private readonly IDbConnection conexao;
        public CategoryRepositorie(IConfiguration conf) => conexao = new SqlConnection("Data Source=localhost,1433;Initial Catalog=CastGroup;Persist Security Info=False;User ID=tmds;Password=tmds;MultipleActiveResultSets=False;");

        public List<Category> GetCategory()
        {
            var dados = conexao.Query<dynamic>(
                        "SELECT R.Id,R.Description,E.SubjectDescription as Courses_SubjectDescription,E.StartDate as Courses_StartDate,E.EndDate as Courses_EndDate,E.NumberStudents as Courses_NumberStudents,E.Id as Courses_Id " +
                        "FROM dbo.Category R " +
                        "INNER JOIN dbo.Course E ON E.IdCategory = R.id");
            AutoMapper.Configuration.AddIdentifier(
                typeof(Category), "Id");
            AutoMapper.Configuration.AddIdentifier(
                typeof(Course), "Id");
            List<Category> categories = (AutoMapper.MapDynamic<Category>(dados)
                as IEnumerable<Category>).ToList();
            return categories;

        }
        public Category GetCategoryId(int Id)
        {
            return this.conexao.Query<Category>("SELECT * FROM Category WHERE @Id = Id", new { Id = Id }).SingleOrDefault();
        }
        public void InsertCategory(Category Description)
        {
            this.conexao.Execute(@"INSERT Category(Description) VALUES (@Description)",
             new { Description = Description.Description });
        }
        public void DeleteCategory(int Id)
        {
            this.conexao.Execute(@"DELETE FROM Category WHERE @Id = id", new { Id = Id });
        }
        public void UpdateCategory(Category Description)
        {
            this.conexao.Execute("UPDATE Category SET Description=@Descriptiong WHERE Id=" + Description.Id,
           new { Description = Description.Description });
        }
    }
}
