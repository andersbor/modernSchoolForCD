using Microsoft.AspNetCore.Identity;

namespace modernSchoolForCD.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Semester { get; set; }

        override
        public string ToString()
        {
            return Id + " " + Name + " " + Semester;
        }

        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            if (Name.Length < 2)
            {
                throw new ArgumentException("Name must be at least 2 characters long");
            }
        }

        public void ValidateSemester()
        {
            if (Semester < 1 || Semester > 8)
            {
                throw new ArgumentException("Semester must be between 1 and 8");
            }
        }

        public void Validate()
        {
            ValidateName();
            ValidateSemester();
        }
    }
}
