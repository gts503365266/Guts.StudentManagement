using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
               new Student
               {
                   Id = 1,
                   Name = "孙悟空",
                   ClassName = ClassNameEnum.FirstGrade,
                   Email = "16621171920@163.com"
               },
               new Student
               {
                   Id = 2,
                   Name = "猪八戒",
                   ClassName = ClassNameEnum.GradeThree,
                   Email = "18862681920@163.com"
               }
               );
        }
    }
}
