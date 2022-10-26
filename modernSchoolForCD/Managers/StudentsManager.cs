using modernSchoolForCD.Models;
using System.Runtime.ConstrainedExecution;

namespace modernSchoolForCD.Managers
{
    public class StudentsManager
    {
        private static int _nextId = 1;
        private static readonly List<Student> Data = new()
        {
            new Student {Id = _nextId++, Name = "John", Semester = 1},
            new Student {Id = _nextId++, Name = "Jane", Semester = 2},
            new Student {Id = _nextId++, Name = "Jack", Semester = 3},
            new Student {Id =_nextId++, Name = "Joe", Semester = 3}
        };

        public List<Student> GetAll()
        {
            return Data;
        }

        public Student? GetById(int id)
        {
            return Data.Find(s => s.Id == id);
        }

        public Student Add(Student student)
        {
            student.Validate();
            student.Id = _nextId++;
            Data.Add(student);
            return student;
        }
    }
}
