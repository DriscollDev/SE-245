using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FName = txtFName.Text;
            person.MName = txtMName.Text;
            person.LName = txtLName.Text;
            person.Street1 = txtStreet1.Text;
            person.Street2 = txtStreet2.Text;
            person.City = txtCity.Text;
            person.State = txtState.Text;
            person.Zip = txtZip.Text;
            person.Phone = txtPhone.Text;
            person.Email = txtEmail.Text;
            lblFeedback.Text = $"Person added: {txtFName.Text} {txtLName.Text}";
            resFName.Text += person.FName;
            resMName.Text += person.MName;
            resLName.Text += person.LName;
            resStreet1.Text += person.Street1;
            resStreet2.Text += person.Street2;
            resCity.Text += person.City;
            resState.Text += person.State;
            resZip.Text += person.Zip;
            resPhone.Text += person.Phone;
            resEmail.Text += person.Email;
        }
    }
}
