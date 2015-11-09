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
        public void Creat_school_by_name()
        {
            Assert.Throws<ArgumentException>(() => new School(null));
            Assert.Throws<ArgumentException>(() => new School(""));

            School s = new School("Intech");
            Assert.That(s.Name, Is.EqualTo("Intech"));

        }
        [Test]
        public void Creat_classroom_by_name()
        {
            Assert.Throws<ArgumentException>(() => new Classroom(null));
            Assert.Throws<ArgumentException>(() => new Classroom(""));

            Classroom s = new Classroom("Salle_01");
            Assert.That(s.Name, Is.EqualTo("Salle_01"));

        }
        [Test]
        public void Creat_teatcher_by_name()
        {
            Assert.Throws<ArgumentException>(() => new Teacher(null,null));
            Assert.Throws<ArgumentException>(() => new Teacher("",""));

            Teacher s = new Teacher("Antoine","Grandiere");
            Assert.That(s.Name, Is.EqualTo("Antoine"));
            Assert.That(s.FirstName, Is.EqualTo("Grandiere"));
        }
        [Test]
        public void Creat_pupil_by_name()
        {
            Assert.Throws<ArgumentException>(() => new Pupil(null, null));
            Assert.Throws<ArgumentException>(() => new Pupil("", ""));

            Pupil s = new Pupil("Andrian", "Kabobo");
            Assert.That(s.Name, Is.EqualTo("Andrian"));
            Assert.That(s.FirstName, Is.EqualTo("Kabobo"));
        }
        [Test]
        public void Creat_promotion_by_name()
        {
            Assert.Throws<ArgumentException>(() => new Promotion(null));
            Assert.Throws<ArgumentException>(() => new Promotion(""));

            Promotion s = new Promotion("Semestre_2");
            Assert.That(s.Name, Is.EqualTo("Semestre_2"));
        }
        [Test]
        public void Add_promotion_by_school()
        {
            School s = new School("Intech");
            Promotion c = s.AddPromotion("S2");

            Assert.That(c.Name, Is.EqualTo("S2"));
            Assert.Throws<ArgumentException>(() => s.AddPromotion(null));
            Assert.Throws<ArgumentException>(() => s.AddPromotion(""));
        }
        [Test]
        public void Find_promotion_by_school()
        {
            School s = new School("Intech");
            Promotion c = s.AddPromotion("S2");

            Assert.That(s.FindPromotion("S2"), Is.SameAs(c));
            Assert.That(s.FindPromotion("S3"), Is.Null);

            Promotion c1 = s.AddPromotion("S3");

            Assert.That(s.FindPromotion("S2"), Is.SameAs(c));
            Assert.That(s.FindPromotion("S3"), Is.SameAs(c1));
            Assert.That(s.FindPromotion("S4"), Is.Null);

        }
        [Test]
        public void Remove_promotion_by_school()
        {
            School s = new School("Intech");
            Promotion c = s.AddPromotion("S2");

            Assert.That(s.RemovePromotion(c), Is.True);
            Assert.That(s.RemovePromotion(c), Is.False);



        }
   }
}
