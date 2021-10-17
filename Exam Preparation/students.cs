using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }
        public int Capacity { get; }

        public int Count => students.Count;

       public string RegisterStudent(Student student)
        {
            if (Capacity<=Count)
            {
                return "No seats in the classroom";
            }
            students.Add(student);
            return $"Added syudent {student.FirstName} {student.LasttName}";
        }

        public string DismissStudent(string firstName, string lastName)
        {
            bool isStudentExisted = students.Exists(x => x.FirstName == firstName && x.LasttName == lastName);
            if (isStudentExisted)
            {
                students.Remove(students.FirstOrDefault(x => 
                x.FirstName == firstName && x.LasttName == lastName));
                return $"Dismissed student {firstName} {lastName}";
            }
            return $"Student not found";
        }
        public string GetSubjectInfo(string subject)
        {
            var studentsSubject = students.Where(x => x.Subject == subject).ToList();
            if (studentsSubject.Count>0)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine($"Students");

                foreach (Student student in studentsSubject)
                {
                    sb.AppendLine($"{student.FirstName} {student.LasttName}");
                }
                return sb.ToString().TrimEnd();
            }
            return $"No students entolled for the subject";
        }
        public int GetStudentsCount() => Count;

        public Student GetStudent(string firstName, string lastName)
        {
            var currStudent = students.FirstOrDefault(x => 
            x.FirstName == firstName && x.LasttName == lastName);
            return currStudent;
        }
    }
}
