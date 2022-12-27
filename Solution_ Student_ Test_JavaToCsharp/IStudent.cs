using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution__Student__Test_JavaToCsharp
{
    internal interface IStudent<T>
    {
        public List<Student> addStudent();
        public List<Student> updateStudent();
        public List<Student> deleteStudent();
        public Student getStudentByName(string name);
        public Student getStudentById(int id);
        public void showAllStudent();
        
    }
}
