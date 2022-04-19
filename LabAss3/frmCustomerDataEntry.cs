using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAss3
{
    public partial class frmCustomerDataEntry : Form
    {
        public frmCustomerDataEntry()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status = "";

            if (radioMale.Checked) Gender = "male";
            else Gender = "Female";
            if (chkReading.Checked) Hobby = "reading";
            else Hobby = "Painting";
            if (radioMarried.Checked) Status = "Married";
            else Status = "Unmarried";

            frmCustomerDataEntry objPreview = new frmCustomerDataEntry();
            objPreview.SetValues(txtName.Text, cmbCountry.Text, Gender, Hobby, Status);

            try
            {
                frmCustomerPreview objVal= new frmCustomerPreview();
                objVal.CheckCustomerName(txtName.Text);

                frmCustomerPreview objrPreview = new frmCustomerPreview();
                objPreview.SetValues(txtName.Text, cmbCountry.Text, Gender, Hobby, Status);
                objPreview.Show();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString()); }
        }
        
        
        private void SetValues(string text1, string text2, string gender, string hobby, string status)
        {
            throw new NotImplementedException();
        }
        
    }
}
