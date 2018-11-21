using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21._11._2018
{
    abstract class Human
    {
        private string _name;
        private string _surname;

        public string Name

        {
            get
            {
                return this._name;
            }
        }
        public string Surname

        {
            get
            {
                return this._surname;
            }
        }

        public Human(string name,string surname)
        {
            this._name = name;
            this._surname = surname;
        }

        private DateTime _birthday;
        public void SetBirthday(string date)
        {
            this._birthday = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        }
        public void SetBirthday(DateTime date)
        {
            this._birthday = date;
        }
        public int GetAge()
        {
            return Convert.ToInt32(DateTime.Now.Subtract(this._birthday).TotalDays / 365);
        }

    }
}
