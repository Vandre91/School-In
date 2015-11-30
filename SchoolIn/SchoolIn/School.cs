﻿using System;
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
        }
        public void Save(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new System.IO.FileStream(path, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(file, this);
            }
        }
        public static School Load(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return (School)formatter.Deserialize(file);
            }
        }
        public Promotion AddPromotion(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
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
                throw new ArgumentException();

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

        public ICollection<Teacher> Teachers
        {
            get { return _listteacher.Values; }
        }

        public ICollection<Classroom> Classrooms
        {
            get { return _listclassroom.Values; }
        }

        public ICollection<Promotion> Promotions
        {
            get { return _listpromotion.Values; }
        }
        public bool RemovePromotion(Promotion i)
        {
            if (i == null)
                throw new ArgumentException();

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
        public Classroom AddClassroom(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
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
        public Teacher AddTeacher(string name, string firstname)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentException();
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
                throw new ArgumentException();

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
