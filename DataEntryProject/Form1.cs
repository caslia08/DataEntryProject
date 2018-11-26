using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntryProject
{
    public partial class FrmDataEntry : Form
    {
        TimeSpan elapsedTime;
        DateTime lastElasped;
        public FrmDataEntry()
        {
            InitializeComponent();
        }

        private void GrbDataEntry_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtaddress.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtzip.Clear();
            txtName.Focus();
        }

        private void timTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime += DateTime.Now - lastElasped;
            lastElasped = DateTime.Now;
            textBox1.Text = Convert.ToString(new TimeSpan(elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds));



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            btnstart.Enabled = false;
            btnPause.Enabled = true;
            timTimer.Enabled = true;
            GrbDataEntry.Enabled = true;
            txtName.Focus();
            lastElasped = DateTime.Now;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnstart.Enabled = true;
            btnPause.Enabled = false;
            GrbDataEntry.Enabled = false;

            timTimer.Enabled = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string dataentry;

            if (txtName.Text.Equals("") || 
                txtaddress.Text.Equals("") || 
                txtProvince.Text.Equals("") || 
                txtCity.Text.Equals("") || 
                txtzip.Text.Equals(""))
            {
                MessageBox.Show("Each box must have input", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            dataentry = txtName.Text + "\r\n" + txtaddress.Text + "\r\n" + txtCity.Text + "\r\n" + txtProvince.Text + "\r\n" + txtzip.Text;
            MessageBox.Show(dataentry, "Data entry", MessageBoxButtons.OK);
            btnClear.PerformClick();

        }

        private void txtinput_keypress(object sender, KeyPressEventArgs e)
        {
            string textBoxSender = ((TextBox)sender).Name; //casts sender as Textbox allows us to acess all the functions

            if (e.KeyChar == 13) // keychar that corresponds with enter key - google rest
            {
                switch (textBoxSender)
                {
                    case "txtName":
                        txtaddress.Focus();
                        break;
                    case "txtaddress":
                        txtCity.Focus();
                        break;
                    case "txtCity":
                        txtProvince.Focus();
                        break;
                    case "txtProvince":
                        txtzip.Focus();
                        break;
                    case "txtzip":
                        btnAccept.Focus();
                        break;
                }
            }

            if (textBoxSender.Equals("txtzip")) //Data Validation for input of txtzip box
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;

                }

            }
        }

        private void btnButton_Hover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Aqua; //sender is a generic object needs to type cast
                                                     //
        }

        private void btnButtons_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = SystemColors.Control;
        }
    }
}
