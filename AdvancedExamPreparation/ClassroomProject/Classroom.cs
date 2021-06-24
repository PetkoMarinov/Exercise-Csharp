using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            students = new List<Student>();
            Capacity = capacity;
        }

        public int Count { get => this.students.Count; }
        public int Capacity { get; set; }

        public string RegisterStudent(Student student)
        {
            if (Capacity>Count)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}"; 
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            if (students.Any(s=>s.FirstName==firstName && s.LastName==lastName))
            {
                students.Remove(GetStudent(firstName, lastName));
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            if (students.Any(s=>s.Subject==subject))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");

                foreach (var student in students)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }

                return sb.ToString().TrimEnd();
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }

        public int GetStudentsCount()
        {
            return students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            return students.Find(s => s.FirstName == firstName && s.LastName == lastName);
        }
    }
}
