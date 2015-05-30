using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_2
{
    public class ClsStudent
    {
        private string _ID;
        private string _Name;
        private DateTime _DOB = DateTime.Today;
        private decimal _Balance;

        public override string ToString()
        {
            return _ID + "\n" + _Name;
        }

        public string ID
        {
            get { return _ID; }
            set 
            {
                if (string.IsNullOrEmpty(value.Trim())) //means no empty ids and it trims the leading or following blanks
                    _ID = value;
                else
                    throw new Exception("You %&%@#!!...");
            }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public DateTime DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        public decimal Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
    }
}
