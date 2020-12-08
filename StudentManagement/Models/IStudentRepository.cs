using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public interface IStudentRepository
    {
        /// <summary>
        /// 通过 Id 来获取学生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Student GetStudent(int id);
    }
}
