using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution__Student__Test_JavaToCsharp
{
    internal class Student
    {
       

        public int idStudent { get; set; }
        public string nameStudent { get; set; }
        public bool genderStudent { get; set; }
        public DateTime dobStudent { get; set; }
        public string classStudent { get; set; }
        public Student() { }

        public Student(int idStudent, string? nameStudent, bool genderStudent, DateTime dobStudent, string? classStudent)
        {
            this.idStudent = idStudent;
            this.nameStudent = nameStudent;
            this.genderStudent = genderStudent;
            this.dobStudent = dobStudent;
            this.classStudent = classStudent;
        }

        public override string ToString()
        {
            return $"{{{nameof(idStudent)}={idStudent.ToString()} | {nameof(nameStudent)}={nameStudent} |" +
                $"  {nameof(genderStudent)}={genderStudent.ToString()}  |  " +
                $"{nameof(dobStudent)}={dobStudent.ToString("yyyy/MM/dd")} |  " +
                $"{nameof(classStudent)}={classStudent}}}";
        }
    }
}
