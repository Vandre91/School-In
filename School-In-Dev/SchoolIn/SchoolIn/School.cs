using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    [Serializable]
    public class School
    {
        string _name;
        string _address;
        Dictionary<string, Promotion> _listpromotion;
        Dictionary<string, Classroom> _listclassroom;
        Dictionary<string, Teacher> _listteacher;
        Dictionary<string, Pupil> _listpupil;
        Dictionary<string, Course> _listcourse;
        public School(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }

            _name = name;
            _listpromotion = new Dictionary<string, Promotion>();
            _listclassroom = new Dictionary<string, Classroom>();
            _listteacher = new Dictionary<string, Teacher>();
            _listpupil = new Dictionary<string, Pupil>();
            _listcourse = new Dictionary<string, Course>();
        }
        public void Save(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream file = new System.IO.FileStream(path, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(file, this);
            }
        }
        public static  School Load(string path)

        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return (School)formatter.Deserialize(file);
            }
        }

        // COURSE
        public Course AddCourse(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }

            if (_listcourse.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            Course c = new Course(name, this);
            _listcourse.Add(name, c);
            return c;
        }

        public Course FindCourse(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new NullReferenceException();

            if (_listcourse.ContainsKey(name))
            {
                Course c = _listcourse[name];
                return c;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public bool RemoveCourse(Course c)
        {
            if (c == null)
                throw new NullReferenceException();

            string name = c.Name;

            if (_listcourse.ContainsKey(name))
            {
                _listcourse.Remove(name);
                return true;
            }
            else
            {
                return false;
            }
        }
        public ICollection<Course> Course
        {
            get { return _listcourse.Values; }
        }

        //PROMOTION

        public Promotion AddPromotion(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }

            if (_listpromotion.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            Promotion promo = new Promotion(name, this);
            _listpromotion.Add(name, promo);
            return promo;
        }
        public Promotion FindPromotion(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new NullReferenceException();

            if (_listpromotion.ContainsKey(name))
            {
                Promotion promo = _listpromotion[name];
                return promo;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public bool RemovePromotion(Promotion i)
        {
            if (i == null)
                throw new NullReferenceException();

            string name = i.Name;

            if (_listpromotion.ContainsKey(name))
            {
                Promotion p = _listpromotion[name];
                _listpromotion.Remove(name);

                return true;
            }
            else
            {
                return false;
            }
        }
        public ICollection<Promotion> Promotion
        {
            get { return _listpromotion.Values; }
        }


        //Classroom

        public Classroom AddClassroom(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new NullReferenceException();
            }

            if (_listclassroom.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            Classroom classroom = new Classroom(name, this);
            _listclassroom.Add(name, classroom);
            return classroom;
        }
        public Classroom FindClassroom(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException();

            if (_listclassroom.ContainsKey(name))
            {
                Classroom classroom = _listclassroom[name];
                return classroom;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public bool RemoveClassroom(Classroom c)
        {
            if (c == null)
                throw new ArgumentException();

            string name = c.Name;

            if (_listpromotion.ContainsKey(name))
            {
                _listpromotion.Remove(name);
                return true;
            }
            else
            {
                return false;
            }
        }
        public ICollection<Classroom> Classroom
        {
            get { return _listclassroom.Values; }
        }

        //TEACHER

        public Teacher AddTeacher(string name, string firstname)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(firstname))
            {
                throw new NullReferenceException();
            }

            if (_listteacher.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            Teacher teacher = new Teacher(name, firstname, this);
            _listteacher.Add(name, teacher);
            return teacher;
        }

        public Teacher FindTeacher(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new NullReferenceException();

            if (_listteacher.ContainsKey(name))
            {
                Teacher teacher = _listteacher[name];
                return teacher;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public bool RemoveTeacher(Teacher t)
        {
            if (t == null)
                throw new ArgumentException();

            string name = t.Name;

            if (_listteacher.ContainsKey(name))
            {
                _listteacher.Remove(name);
                return true;
            }
            else
            {
                return false;
            }
        }
        public ICollection<Teacher> Teacher
        {
            get { return _listteacher.Values; }
        }

        //PUPIL

        public Pupil AddPupil(string name, string firstname)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(firstname))
            {
                throw new NullReferenceException();
            }

            if (_listpromotion.ContainsKey(name))
            {
                throw new ArgumentException();
            }

            Pupil pupil = new Pupil(name,firstname, this);
            _listpupil.Add(name, pupil);
            return pupil;
        }
        public Pupil FindPupil(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException();

            if (_listpupil.ContainsKey(name))
            {
                Pupil pupil = _listpupil[name];
                return pupil;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public bool RemovePupil(Pupil p)
        {
            if (p == null)
                throw new ArgumentException();

            string name = p.Name;

            if (_listpupil.ContainsKey(name))
            {
                _listpupil.Remove(name);
                return true;
            }
            else
            {
                return false;
            }
        }
        public ICollection<Pupil> Pupil
        {
            get { return _listpupil.Values; }
        }

        //CONTROL

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public int NbPromotion()
        {
            return _listpromotion.Count();
        }
    }
}
