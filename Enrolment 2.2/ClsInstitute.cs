using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_2._2
{
    class ClsInstitute
    {
        private static List<ClsStudent> _StudentList = new List<ClsStudent>();

        public static List<ClsStudent> StudentList
        {
            get { return ClsInstitute._StudentList; }
//            set { ClsInstitute._StudentList = value; }
        }

        public static decimal TotalBalance()
        {
            decimal lcTotal = 0;
            foreach (ClsStudent lcStudent in _StudentList)
                lcTotal += lcStudent.Balance;
            return lcTotal;
        }



    }
}
