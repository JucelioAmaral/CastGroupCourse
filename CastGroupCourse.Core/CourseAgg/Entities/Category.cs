using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CastGroupCourse.Core.CourseAgg.Entities
{
   public class Category
    {
        [FromQuery(Name = "Id")]
        [Required]
        public int Id { get; set; }

        [FromQuery(Name = "Description")]
        [Required]
        public string Description { get; set; }       
    }
}
