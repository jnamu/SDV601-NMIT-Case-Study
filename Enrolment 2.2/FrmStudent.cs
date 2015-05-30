using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment_2._2
{
    public partial class FrmStudent : Form
    {
        protected ClsStudent _Student;

        public FrmStudent()
        {
            InitializeComponent();
        }

        public bool ShowDialog(ClsStudent prStudent)
        {
            _Student = prStudent;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void updateDisplay()
        {
            try
            {
                txtID.Text = _Student.ID;
                txtName.Text = _Student.Name;
                dtpDOB.Value = _Student.DOB;
                txtBalance.Text = Convert.ToString(_Student.Balance);
                txtID.Enabled = String.IsNullOrEmpty(_Student.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                pushData();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void pushData()
        {
            _Student.ID = txtID.Text;
            _Student.Name = txtName.Text;
            _Student.DOB = dtpDOB.Value;
            _Student.Balance = Convert.ToDecimal(txtBalance.Text);
        }
    }
}
