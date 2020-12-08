using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _studentList;


        public MockStudentRepository()
        {

            _studentList = new List<Student>()
            {
            new Student() { Id = 1, Name = "张三", Email = "Tony-zhang@52abp.com",ClassName="一年级" },
            new Student() { Id = 2, Name = "李四", Email = "lisi@52abp.com" ,ClassName="二年级"},
            new Student() { Id = 3, Name = "王二麻子", Email = "wang@52abp.com" ,ClassName="三年级"},
            };

        }
        public Student GetStudent(int id)
        {
            return _studentList.FirstOrDefault(a => a.Id == id);
        }

        IEnumerable<Student> IStudentRepository.GetAllStudent()
        {
            return _studentList;
        }
    }
}
