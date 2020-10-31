using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> _students;
        private int _capacity;
        public List<Student> Students { get; set; }

        public Classroom(int capacity)
        {
            this._capacity = capacity;
            this._students = new List<Student>();
        }

        public int Capacity
        {
            get => this._capacity;
            set => this._capacity = value;
        }

        public int Count => this._students.Count;

        public string RegisterStudent(Student student)
        {
            if (this._students.Count < this._capacity)
            {
                this._students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            for (int i = 0; i < this._students.Count; i++)
            {
                var current = this._students[i];
                if (current.FirstName != firstName || current.LastName != lastName) continue;
                this._students.Remove(current);
                return $"Dismissed student {firstName} {lastName}";
            }

            return "Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            var sb = new StringBuilder();
            var list = this._students.Where(x => x.Subject == subject).ToList();
            if (list.Count > 0)
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");

                foreach (var student in list)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
                
            }
            else
            {
                sb.AppendLine("No students enrolled for the subject");
            }

            return sb.ToString().Trim();
        }

        public int GetStudentsCount() => this.Count;

        public Student GetStudent(string firstName, string lastName) => this._students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
    }
}
