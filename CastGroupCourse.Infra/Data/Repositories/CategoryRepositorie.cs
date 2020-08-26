using CastGroupCourse.Core.CourseAgg.Entities;
using CastGroupCourse.Core.CourseAgg.Interfaces.Repositories;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CastGroupCourse.Infra.Data.Repositories
{
    public class CategoryRepositorie : ICategory
    {
        private readonly IDbConnection conexao;
        public CategoryRepositorie(IConfiguration conf) => conexao = new SqlConnection("Data Source=localhost,1433;Initial Catalog=CastGroup;Persist Security Info=False;User ID=;Password=;MultipleActiveResultSets=False;");

        public List<Category> GetCategory()
        {
            return this.conexao.Query<Category>("SELECT * FROM Category").ToList();
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
