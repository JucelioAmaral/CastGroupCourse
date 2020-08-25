using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CastGroupCourse.Core.CourseAgg.Entities
{
    public class Course
    {
        [FromQuery(Name = "Id")]
        public int Id { get; set; }

        [FromQuery(Name = "SubjectDescription")]
        [Required]
        public string SubjectDescription { get; set; }

        [FromQuery(Name = "StartDate")]
        [Required]
        public DateTime StartDate { get; set; }

        [FromQuery(Name = "EndDate")]
        [Required]
        public DateTime EndDate { get; set; }

        [FromQuery(Name = "NumberStudents")]
        public DateTime NumberStudents { get; set; }

        [FromQuery(Name = "CategoryId")]
        [Required]
        public int CategoryId { get; set; }
    }
}
