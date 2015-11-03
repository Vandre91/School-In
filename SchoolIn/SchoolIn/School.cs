using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIn
{
    public class School
    {
        string _name;
        string _address;
        Dictionary<string, Promotion> _listpromotion;


        public School(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }
               
            _name = name;
            _listpromotion = new Dictionary<string, Promotion>();
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

            Promotion promo = new Promotion(name);
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

        public bool RemovePromotion(Promotion i)
        {
            if (i == null)
                throw new ArgumentException();

            string name = i.Name;

            if (_listpromotion.ContainsKey(name))
            {
                Promotion myingredientinrecipe = _listpromotion[name];
                _listpromotion.Remove(name);

                return true;
            }
            else
            {
                return false;
            }
       }
        public string Name
        {
            get { return _name;  }
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
