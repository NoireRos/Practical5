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
        public Form1()
        {
            InitializeComponent();
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            string name, last, middle, birth, barangay, complete;
            name = firstNameText.Text;
            last = lastNameText.Text;
            middle = middleInitialText.Text;
            birth = birthplaceText.Text;
            barangay = barangayText.Text;
            complete = addressText.Text;

            DateTime start = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime end = DateTime.Now;
            TimeSpan span = end.Subtract(start);
            double days = span.TotalDays;
            double years = Math.Truncate(days / 365);
            ageTextBox.Text = Convert.ToString(years);

            string all;
            all = "Complete Name: " + name + " " + last + " " + middle + "\n" + "Age: " + years +"\n" + "Sex: " + sexComboBox.Text + "\n" + "Birth Place: " + birth + "\n" + "Complete Address: " + complete + "\n" + "Barangay: " + barangay + "\n" + "Number: " + precintCombo.Text;
            if (years >= 18)
            {
                string title = "CONGRATS YOU CAN VOTE";
                string message = all;
                MessageBox.Show(message, title, MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("YOU ARE NOT ELIGIBLE TO VOTE!!");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameText.Clear();
            lastNameText.Clear();
            middleInitialText.Clear();
            ageTextBox.Clear();
            dateTimePicker1.ResetText();
            addressText.Clear();
            birthplaceText.Clear();
            barangayText.Clear();
            sexComboBox.Text = "";
            precintCombo.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
