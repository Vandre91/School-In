using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    [Serializable]
    public class Pupil
    {
        string _name;
        string _firstname;
        string _city;
        string _age;
        string _phone;
        Dictionary<string, int> _listnote;
        bool _ismissing;
        School _school;


        public Pupil(string name, string firstname, School school)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentException();
            }

            _name = name;
            _firstname = firstname;
            _school = school;
            _listnote = _listnote = new Dictionary<string, int>();
        }
        public void AddNote(string teaching, int note)
        {
            if (string.IsNullOrWhiteSpace(teaching))
            {
                throw new ArgumentException();
            }
            _listnote.Add(teaching, note);
        }
        public void RemoveNote(string teaching)
        {
            if (_listnote.ContainsKey(teaching))
            {
                _listnote.Remove(teaching);
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public bool IsMissing
        {
            get { return _ismissing; }
            set { _ismissing = value; }
        }
    }
}
