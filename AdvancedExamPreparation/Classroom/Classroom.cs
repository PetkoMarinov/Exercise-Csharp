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

        public void RegisterStudent(Student student)
        {
            if (Capacity>Count)
            {
                students.Add(student);
                Console.WriteLine($"Added student {student.FirstName} {student.LastName}"); 
            }
            else
            {
                Console.WriteLine("No seats in the classroom");
            }
        }

        public void DismissStudent(string firstName, string lastName)
        {
            if (students.Any(s=>s.FirstName==firstName && s.LastName==lastName))
            {
                students.Remove(GetStudent(firstName, lastName));
                Console.WriteLine($"Dismissed student {firstName} {lastName}");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }

        public void GetSubjectInfo(string subject)
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

                Console.WriteLine(sb.ToString().TrimEnd());
            }
            else
            {
                Console.WriteLine("No students enrolled for the subject");
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
