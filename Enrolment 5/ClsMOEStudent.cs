using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_2.Enrolment_5
{
    class ClsMOEStudent : ClsStudent
    {
        private decimal _LoanAmount;
        private bool _FullTime;
        private static FrmMOEStudent _Form = new FrmMOEStudent();

        public decimal LoanAmount
        {
            get { return _LoanAmount; }
            set { _LoanAmount = value; }
        }

        public bool FullTime
        {
            get { return _FullTime; }
            set { _FullTime = value; }
        }
        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }
    }
}
