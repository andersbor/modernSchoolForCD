using Microsoft.VisualStudio.TestTools.UnitTesting;
using modernSchoolForCD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modernSchoolForCD.Models.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void ToStringTest()
        {

        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            Student student = new() { Name = "John", Semester = 3 };
            student.ValidateName();
            Student studentNameNull = new() { Name = null, Semester = 3 };
            Assert.ThrowsException<ArgumentNullException>(() => studentNameNull.ValidateName());
        }

        [TestMethod()]
        public void ValidateSemesterTest()
        {

        }

        [TestMethod()]
        public void ValidateTest()
        {

        }
    }
}