using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution__Student__Test_JavaToCsharp
{
    internal class Controller : IStudent<Student>
    {
        List<Student> list = new List<Student>() { 
            new Student(){idStudent = 1 ,nameStudent = "Anh", genderStudent = true, dobStudent =  new DateTime(2000, 01, 01),classStudent= "aaa" }
        
        };
        public List<Student> addStudent()
        {
            
            Console.WriteLine("----------------------------------");
            Console.WriteLine("ADD NEW STUDENT");
            Console.WriteLine(" Enter ID:");
            int idStudent = int.TryParse(Console.ReadLine(), out int r) ? r : 0;
            Console.WriteLine("Enter Name:");
            string nameStudent = Console.ReadLine();
            Console.WriteLine("Enter gender:");
            bool gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter DOB:");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dob);
            Console.WriteLine("Enter Class ID:");
            string classid = Console.ReadLine();
            Student stu = new Student(idStudent, nameStudent, gender, dob, classid);
            list.Add(stu);
            
            return list;
        }

        public List<Student> deleteStudent()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("DELETE STUDENT");
            int idStudent = int.TryParse(Console.ReadLine(), out int r) ? r : 0;
            var t = from stu in list where stu.idStudent == idStudent select stu;
            if (t.Count() == 0)
            {
                Console.WriteLine("This student was not found!");
            } else
            {
                var  e = list.Where(stu => stu.idStudent ==  idStudent).ToList();
                foreach(var i in e) { list.Remove(i); }
            }
            return list;
        }



        public Student getStudentById(int id)
        {

            var t = list.Where(stu => stu.idStudent == id).ToList();
            Student student = t.FirstOrDefault();
            return student;
        }

        public Student getStudentByName(string name)
        {
            var t = list.Where(stu => stu.nameStudent == name).ToList();
            Student student = t.FirstOrDefault();
            return student;
        }

        public void showAllStudent() =>list.ForEach(Console.WriteLine);
        

        public List<Student> updateStudent()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Update Student");
            Console.WriteLine("Enter Student ID:");
            int idStudent = int.TryParse(Console.ReadLine(), out int r) ? r : 0;
            var t = list.Where(stu => stu.idStudent == idStudent).ToList();
            if (t.Count == 0)
            {
                Console.WriteLine("This idStudent was not found!");
            }
            else
            {
                foreach (var i in list)
                    if (i.idStudent == idStudent)
                    {
                        Console.WriteLine(i.ToString());
                        Console.WriteLine("Enter Name:");
                        string nameStudent = Console.ReadLine();
                        Console.WriteLine("Enter Gender(true)/nu(flase)");
                        bool genderStudent = bool.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap ngay sinh:");
                        DateTime  dobStudent = DateTime.Parse(Console.ReadLine());
                        i.nameStudent = nameStudent;
                        i.genderStudent = genderStudent;
                        i.dobStudent = dobStudent;
                    }
            }
            return list;
        }
    }
}
