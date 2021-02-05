using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        public List<Student> students;
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();

        }

        public int Capacity { get; set; }
        public int Count { get { return students.Count; } }

        public string RegisterStudent(Student student)
        {
            if (Capacity > students.Count)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student currentStudent = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (students.Contains(currentStudent))
            {
                students.Remove(currentStudent);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return $"Student not found";
            }
        }
        public string GetSubjectInfo(string subject)
        {
            Student cur = students.FirstOrDefault(s => s.Subject == subject);

                if (cur != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine($"Students:");
                foreach (var currentstudent in students.Where(s => s.Subject == subject))
                {
                    sb.AppendLine($"{currentstudent.FirstName} {currentstudent.LastName}").ToString().TrimEnd();

                }
                return sb.ToString().Trim();
            }
                else
            {
                return "No students enrolled for the subject";
            }
            


        }

        public int GetStudentsCount()
        {
            return students.Count();
        }
     
        public Student GetStudent(string firstName, string lastName)
        {
            Student currentStudent = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            return currentStudent;
        }
    }
}
