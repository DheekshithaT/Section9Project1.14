using System;
using System.Collections.Generic;
using System.Linq;
namespace RainbowSchool
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
    }

    public class Teacher
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
    }

    public class Subject
    {
        public string Name { get; set; }
        public string SubjectCode { get; set; }
        public Teacher Teacher { get; set; }
    }

    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Teacher> teachers = new List<Teacher>();
        static List<Subject> subjects = new List<Subject>();
        static void Data()
        {
//Students Data:
            students.Add(new Student { Name = "Prabhas", Class = "CSE", Section = "Section A" });
            students.Add(new Student { Name = "Adivi Sesh", Class = "IT", Section = "Section E" });
            students.Add(new Student { Name = "Vijay Thalapathy", Class = "MECH", Section = "Section C" });
            students.Add(new Student { Name = "Anushka", Class = "CSE", Section = "Section A" });
            students.Add(new Student { Name = "Sree Leela", Class = "MBA", Section = "Section B" });
//Teachers Data:
            teachers.Add(new Teacher { Name = "Rajamouli", Class = "CSE,ECE" , Section = "Section A" });
            teachers.Add(new Teacher { Name = "Trivikram", Class = "IT", Section = "Section E" });
            teachers.Add(new Teacher { Name = "Prashanth Neel", Class = "MECH,MBA", Section = "Section B" });
 //Subjects Data:
            subjects.Add(new Subject { Name = "C++", SubjectCode = "CS101", Teacher = teachers[0] });
            subjects.Add(new Subject { Name = "JAVA", SubjectCode = "IT102", Teacher = teachers[1] });
            subjects.Add(new Subject { Name = "PHYSICS", SubjectCode = "MECH103", Teacher = teachers[2] });
            subjects.Add(new Subject { Name = "ART", SubjectCode = "ARTE10", Teacher = teachers[0] });
            subjects.Add(new Subject { Name = "BE", SubjectCode = "MBA106", Teacher = teachers[2] });
        }

        static void Classinfo(string className)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine($"{className} STUDENT LIST:");
            Console.WriteLine("==========================================");
            var studentsInClass = students.Where(s => s.Class == className);
            foreach (var student in studentsInClass)
            {
                Console.WriteLine($"{student.Name} ({student.Section})");
            }
            Console.WriteLine();
        }

        static void Subjectsinfo(string teacherName)
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine($"LIST OF SUBJECTS TAUGHT BY LECTURER: {teacherName}");
            Console.WriteLine("=======================================================");
            var subjectsByTeacher = subjects.Where(s => s.Teacher.Name == teacherName);
            foreach (var subject in subjectsByTeacher)
            {
                Console.WriteLine($" {subject.Name} ({subject.SubjectCode})");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Data();
            Classinfo("CSE");
            Classinfo("IT");
            Classinfo("MBA");
            Classinfo("MECH");
            Subjectsinfo("Rajamouli");
            Subjectsinfo("Prashanth Neel");
            Subjectsinfo("Trivikram");
        }
    }
}
