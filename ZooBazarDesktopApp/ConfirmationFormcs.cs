using Domain.Entity;
using Domain.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazarDesktopApp
{
    public partial class ConfirmationFormcs : Form
    {
        ViewDetails employeeDetailsForm;
      
        public ConfirmationFormcs(ViewDetails employeeDetailsForm)
        {
            InitializeComponent();
            this.employeeDetailsForm = employeeDetailsForm;
           
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

            employeeDetailsForm.TerminationConfirmed();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
