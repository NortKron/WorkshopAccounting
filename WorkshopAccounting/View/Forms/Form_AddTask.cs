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
    public partial class Form_AddTask : Form
    {
        MainForm _mainForm;

        public Form_AddTask(MainForm mainForm)
        {
            InitializeComponent();
            
            _mainForm = mainForm;

            comboBox_State.DataSource = _mainForm.listState.Values.ToList();
            comboBox_Employee.DataSource = _mainForm.listEmployees.Values.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainForm.AddTasks(
                new Tasks
                {
                    Name = textBox1.Text,
                    Descriptioin = textBox2.Text,
                    DateTime_Start = dateTimePicker1.Value,
                    DateTime_End = dateTimePicker2.Value,
                    State = _mainForm.listState.ElementAt(comboBox_State.SelectedIndex).Key,
                    Employee = _mainForm.listEmployees.ElementAt(comboBox_Employee.SelectedIndex).Key,
                    Workshop = Int32.Parse(textBox4.Text)
                });
            this.Close();
        }
    }
}
