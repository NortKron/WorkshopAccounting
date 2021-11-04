using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WorkshopAccounting.Model;

namespace WorkshopAccounting.View
{
    public partial class Form_AddEmployee : Form
    {
        MainForm _mainForm;

        public Form_AddEmployee(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainForm.AddEmployee(
                new Employees
                {
                    Employee = textBox1.Text,
                    Position = textBox2.Text,
                    Empl_Date = dateTimePicker1.Value
                });
            this.Close();
        }
    }
}
