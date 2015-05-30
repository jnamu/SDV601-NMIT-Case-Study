using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_2._2
{


    public abstract class ClsStudent
    {
        //public static ClsStudent NewStudent(string prChoice)
        //{
            //string caseSwitch = prChoice;
            //switch (caseSwitch)
            //{
            //    case "International":
            //        return new ClsInternationalStudent();
            //    case "TOP":
            //        return new ClsTopStudent();
            //    default :
            //        return new ClsMOEStudent();
            //}
        //}
        public static ClsStudent NewStudent(int prChoice)
        {
            if (prChoice == 0)
                return new ClsMOEStudent();
            if (prChoice == 1)
                return new ClsInternationalStudent();
            else
                return new ClsTopStudent();
        }
        public static readonly string[] StudentType = { "MOE (local)", "International", "TOP" };

        protected abstract string typeOfStudent();

        private string _ID;
        private string _Name;
        private DateTime _DOB = DateTime.Today;
        private decimal _Balance;

        public override string ToString()
        {
            return _ID + "\t" + _Name + "\t" + typeOfStudent();
        }

        public string ID
        {
            get { return _ID; }
            set
            {
                if (!string.IsNullOrEmpty(value.Trim())) //means no empty ids and it trims the leading or following blanks
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
        public abstract Boolean ViewEdit();

    }
}