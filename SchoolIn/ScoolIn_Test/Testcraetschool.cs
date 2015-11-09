using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SchoolIn.Test
{
    [TestFixture]
    public class Testcreatschool
    {
        [Test]
        public void Creat_school()
        {
            Assert.Throws<ArgumentException>(() => new School(null));
            Assert.Throws<ArgumentException>(() => new School(""));

        }
        [Test]
        public void Creat_classroom()
        {
            Assert.Throws<ArgumentException>(() => new Classroom(null));
            Assert.Throws<ArgumentException>(() => new Classroom(""));

        }
        [Test]
        public void Creat_teatcher()
        {
            Assert.Throws<ArgumentException>(() => new Teacher(null,null));
            Assert.Throws<ArgumentException>(() => new Teacher("",""));
        }
        [Test]
        public void Creat_pupil()
        {
            Assert.Throws<ArgumentException>(() => new Pupil(null, null));
            Assert.Throws<ArgumentException>(() => new Pupil("", ""));
        }
        [Test]
        public void Creat_promotion()
        {
            Assert.Throws<ArgumentException>(() => new Pupil(null, null));
            Assert.Throws<ArgumentException>(() => new Pupil("", ""));
        }
    }
}
