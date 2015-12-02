using NUnit.Framework;
using SchoolIn;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoolIn_Test
{
    [TestFixture]
    public class SerializationTests
    {
        [Test]
        public void save_and_reload()
        {
            string fName = Path.GetTempFileName();

            School sc = new School("Intech");
            sc.Save(fName);
            School sc2 = School.Load(fName);

            Assert.That(sc2.Name, Is.EqualTo(sc.Name));
        }

    }
}
