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
        private Student student = new() { Name = "John", Semester = 3 };
        private Student studentNameNull = new() { Name = null, Semester = 3 };
        private Student studentName1 = new() { Name = "A", Semester = 2 };

        [TestMethod()]
        public void ToStringTest()
        {
            string str = student.ToString();
            Assert.AreEqual("0 John 3", str);
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            student.ValidateName();
            Assert.ThrowsException<ArgumentNullException>(() => studentNameNull.ValidateName());
        }

        [TestMethod()]
        public void ValidateSemesterTest()
        {
            Assert.ThrowsException<ArgumentException>(() => studentName1.ValidateName());
        }

        [TestMethod()]
        public void ValidateTest()
        {

        }
    }
}