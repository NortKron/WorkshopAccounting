using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WorkshopAccounting.Presenter;
using WorkshopAccounting.Model;

namespace WorkshopAccounting.View
{
    public partial class Form_AddTask : Form, ITaskAdd
    {
        #region Presenter Interface Methods
        public string Task_Name
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Task_Description
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public DateTime Task_StartDate
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }

        public bool Task_EndDate_b
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }

        public DateTime Task_EndDate
        {
            get { return dateTimePicker2.Value; }
            set { dateTimePicker2.Value = value; }
        }

        public string Task_Hours
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value.ToString(); }
        }

        public string Task_State
        {
            get { return comboBox_State.Text; }
            set { comboBox_State.Text = value; }
        }

        public string Task_Employee
        {
            get { return comboBox_Employee.Text; }
            set { comboBox_Employee.Text = value; }
        }

        public int Task_Workshop
        {
            get { return Int32.Parse(textBox4.Text); }
            set { textBox4.Text = value.ToString(); }
        }
        public Object DataSource_ListEmployees
        {
            set { comboBox_State.DataSource = value; }
        }
        public Object DataSource_ListStates
        {
            set { comboBox_Employee.DataSource = value; }
        }
        public event EventHandler Task_Add;
        #endregion Presenter Interface Methods

        public Form_AddTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task_Add(sender, e);
            this.Close();
        }
    }
}
