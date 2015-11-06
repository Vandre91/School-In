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
    }
}
