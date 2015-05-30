using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_2.Enrolment_5
{
    class ClsInternationalStudent : ClsStudent
    {
        private string _Country;
        private float _IELTS;
        private static FrmInternationalStudent _Form = new FrmInternationalStudent();

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public float IELTS
        {
            get { return _IELTS; }
            set { _IELTS = value; }
        }
        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }
    }
}
