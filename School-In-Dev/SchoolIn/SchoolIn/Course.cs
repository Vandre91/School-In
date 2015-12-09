using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    [Serializable]
    public class Course
    {
        string _name;
        Dictionary<string, Promotion> _listpromotion;
        Dictionary<string, Teacher> _listteacher;
        Classroom _classroom;
        School _school;
        DateTime _start;
        DateTime _end;

        public Course(string name, School school)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }

            _name = name;
            _school = school;
            _listteacher = new Dictionary<string, Teacher>();
            _listpromotion = new Dictionary<string, Promotion>();
        }

        public void AddPromotion(Promotion p)
        {
            if (p == null)
                throw new NullReferenceException();

            string name = p.Name;
            _listpromotion.Add(name, p);
        }

        public bool ExistPromotion(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new NullReferenceException();

            if (_listpromotion.ContainsKey(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemovePromotion(Promotion p)
        {
            if (p == null)
                throw new NullReferenceException();

            string name = p.Name;

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

        public void AddTeacher(Teacher t)
        {
            if (t == null)
                throw new NullReferenceException();

            string name = t.Name;
            _listteacher.Add(name, t);
        }

        public bool ExistTeacher(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new NullReferenceException();

            if (_listteacher.ContainsKey(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveTeacher(Teacher t)
        {
            if (t == null)
                throw new NullReferenceException();

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

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public School School
        {
            get { return _school; }
            set { _school = value; }
        }
        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }

        public DateTime End
        {
            get { return _end; }
            set { _end = value; }
        }

        public Classroom Classroom
        {
            get { return _classroom; }
            set { _classroom = value; }
        }

        public ICollection<Promotion> Promotion
        {
            get { return _listpromotion.Values; }
        }

        public ICollection<Teacher> Teacher
        {
            get { return _listteacher.Values; }
        }

    }
}
