using System;
using System.Windows.Forms;

using WorkshopAccounting.Presenter;

namespace WorkshopAccounting.View
{
    public partial class Form_AddEmployee : Form, IEmplAdd
    {
        #region Presenter Interface Methods
        public string Employee_Name
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Employee_Position
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public DateTime Employee_Date
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }

        public event EventHandler Employee_Add;
        #endregion Presenter Interface Methods

        public Form_AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Add(sender, e);
            this.Close();
        }
    }
}
