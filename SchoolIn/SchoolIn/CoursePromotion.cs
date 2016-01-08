using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    [Serializable]
    public class CoursePromotion
    {
        string _name;
        List<Promotion> _listpromotion;
        List<Teacher> _listteacher;
        List<Classroom> _listclassroom;
        School _school;
        DateTime _start;
        DateTime _end;
        int _x;
        int _y;

        public CoursePromotion(string name, School school)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }

            _name = name;
            _school = school;
            _listteacher = new List<Teacher>();
            _listpromotion = new List<Promotion>();
            _listclassroom = new List<Classroom>();
        }

        public void AddPromotion(Promotion p)
        {
            if (p == null)
                throw new NullReferenceException();

            _listpromotion.Add(p);
        }

        public bool ExistPromotion(Promotion p)
        {
            if (p == null)
                throw new NullReferenceException();

            if (_listpromotion.Contains(p))
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

            if (_listpromotion.Contains(p))
            {
                _listpromotion.Remove(p);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddClassroom(Classroom c)
        {
            if (c == null)
                throw new NullReferenceException();

            _listclassroom.Add(c);
        }

        public bool ExistClassroom(Classroom c)
        {
            if (c == null)
                throw new NullReferenceException();

            if (_listclassroom.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveClassroom(Classroom c)
        {
            if (c == null)
                throw new NullReferenceException();

            if (_listclassroom.Contains(c))
            {
                _listclassroom.Remove(c);
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

            _listteacher.Add(t);
        }

        public bool ExistTeacher(Teacher t)
        {
            if (t == null)
                throw new NullReferenceException();

            if (_listteacher.Contains(t))
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

            if (_listteacher.Contains(t))
            {
                _listteacher.Remove(t);
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

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public ICollection<Promotion> AllPromotion
        {
            get { return _listpromotion; }
        }

        public ICollection<Teacher> AllTeacher
        {
            get { return _listteacher; }
        }

        public ICollection<Classroom> AllClassroom
        {
            get { return _listclassroom; }
        }
    
    }
}
