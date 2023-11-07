using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Employee employee;
        string menuItem;
        object requst;
        public Form1()
        {
            InitializeComponent();
            employee = new Employee();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(quantityTextBox.Text);
                requst = employee.CopyRequest();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            QualityLabel.Text = employee.Inspect(Newrequest: requst);
            ResultListBox1.Items.Add("Request accepted!");
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobutton = (RadioButton)sender;
            menuItem = ChickenRadio.Text;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobutton = (RadioButton)sender;
            menuItem = EggRadio.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                var result = employee.PrepareFood(request: requst);
                ResultListBox1.Items.Add(item: result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(quantityTextBox.Text);
                requst = employee.NewRequest(quantity, menuItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            quantityTextBox.Text = employee.Inspect(Newrequest:requst);
            ResultListBox1.Items.Add("Request accepted!");
        }
        

    }
}
