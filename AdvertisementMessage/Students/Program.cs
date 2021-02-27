using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    public class Students
    {
        public Students() 
        {
        
        }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string grade { get; set; }

        public override string ToString()
        {
            return $"{firstName} {lastName}: {grade}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < count; i++)
            {
                string[] studentData = Console.ReadLine().Split();

                Students pupil = new Students();
                pupil.firstName = studentData[0];
                pupil.lastName = studentData[1];
                pupil.grade = studentData[2];

                students.Add(pupil);
            }

            students = students.OrderByDescending(x => x.grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }
}
