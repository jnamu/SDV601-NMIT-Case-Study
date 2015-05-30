﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_2._3
{
    [Serializable]
    class ClsTopStudent : ClsStudent
    {
        private string _Referral;
        private static FrmTOPStudent _Form = new FrmTOPStudent();

        public string Referral
        {
          get { return _Referral; }
          set { _Referral = value; }
        }

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }
        protected override string typeOfStudent()
        {
            return "TOP";
        }
    }
}