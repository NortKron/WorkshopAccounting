using System;
using System.Collections.Generic;
using System.Windows.Forms;

using WorkshopAccounting.Presenter;

namespace WorkshopAccounting.View
{
    public partial class MainForm : Form, IMainForm
    {
        public Dictionary<int, string> listState;
        public Dictionary<int, string> listEmployees;

        #region Presenter Interface Methods

        public int Task_Id
        {
            get { return Int32.Parse(textBox_TaskId.Text); }
            set { textBox_TaskId.Text = value.ToString(); }
        }

        public string Task_Name
        {
            get { return textBox_TaskName.Text; }
            set { textBox_TaskName.Text = value; }
        }

        public string Task_Description
        {
            get { return textBox_Description.Text; }
            set { textBox_Description.Text = value; }
        }

        public DateTime Task_StartDate
        {
            get { return dateTimePicker_Start.Value; }
            set { dateTimePicker_Start.Value = value; }
        }

        public bool Task_EndDate_b
        {
            get { return checkBox_DateEnd.Checked; }
            set { checkBox_DateEnd.Checked = value; }
        }

        public DateTime Task_EndDate
        {
            get { return dateTimePicker_End.Value; }
            set { dateTimePicker_End.Value = value; }
        }

        public string Task_Hours
        {
            get { return textBox_Hours.Text; }
            set { textBox_Hours.Text = value.ToString(); }
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
            get { return Int32.Parse(textBox_Workshop.Text); }
            set { textBox_Workshop.Text = value.ToString(); }
        }

        public int Employee_Id
        {
            get { return Int32.Parse(textBox_EmplId.Text); }
            set { textBox_EmplId.Text = value.ToString(); }
        }

        public string Employee_Name
        {
            get { return textBox_Employee.Text; }
            set { textBox_Employee.Text = value; }
        }

        public string Employee_Position
        {
            get { return textBox_Position.Text; }
            set { textBox_Position.Text = value; }
        }

        public DateTime Employee_Date
        {
            get { return dateTimePicker_Employ.Value; }
            set { dateTimePicker_Employ.Value = value; }
        }

        public string Status_Label 
        {
            get { return toolStripStatusLabel1.Text; }
            set { toolStripStatusLabel1.Text = value; }
        }

        public Object DataSource_Tasks
        {
            set { dataGridView_Tasks.DataSource = value; }
        }

        public Object DataSource_Employees
        {
            set { dataGridView_Empl.DataSource = value; }
        }
        public Object DataSource_EmplTasks
        {
            set { dataGridView_EmplTasks.DataSource = value; }
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
        public event EventHandler Task_Save;
        public event EventHandler Task_Delete;

        public event EventHandler Empl_Add;
        public event EventHandler Empl_Save;
        public event EventHandler Empl_Delete;

        public event EventHandler dataGrid_Tasks_Select;
        public event EventHandler dataGrid_Empl_Select;

        #endregion Presenter Interface Methods

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolStripButtonRefresh();
        }

        private void tabControl_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripButtonRefresh();
        }

        private void ToolStripButtonRefresh()
        {
            // активация кнопок на панели инструментов
            switch (tabControl_Main.SelectedIndex)
            {
                case 0:
                    // вкладка "Задачи"
                    toolStripButton_SaveTask.Visible = true;
                    toolStripButton_AddEmployee.Visible = false;

                    break;

                case 1:
                    // вкладка "Сотрудники"
                    toolStripButton_SaveTask.Visible = false;
                    toolStripButton_AddEmployee.Visible = true;

                    break;
            }
        }

        private void button_EmplSave_Click(object sender, EventArgs e) => Empl_Save(sender, e);

        private void button_EmplDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить сотрудника?", "Удаление сотрудника",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Empl_Delete(sender, e);
            }
        }

        private void toolStripButton_AddTask_Click(object sender, EventArgs e)
        {
            Form_AddTask form = new();
            AddTaskPresenter presenter = new(form, this);
            form.ShowDialog();
        }

        private void toolStripButton_AddEmployee_Click(object sender, EventArgs e)
        {
            Form_AddEmployee form = new();
            AddEmployeePresenter presenter = new(form, this);
            form.ShowDialog();
        }

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_About_Click(object sender, EventArgs e) => new Form_About().ShowDialog();

        private void button_TaskDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить задачу?", "Удаление задачи",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Task_Delete(sender, e);
            }
        }

        private void button_TaskSave_Click(object sender, EventArgs e)
        {
             Task_Save(sender, e);
        }

        private void Menu_Tasks_Click(object sender, EventArgs e) => OpenTabWindow(0);
        private void Menu_Employees_Click(object sender, EventArgs e) => OpenTabWindow(1);
        private void OpenTabWindow(int tabIndex)
        {
            tabControl_Main.SelectedIndex = tabIndex;
            ToolStripButtonRefresh();
        }

        private void dataGridView_Tasks_SelectionChanged(object sender, EventArgs e)
        {
            textBox_TaskId.Text = dataGridView_Tasks
                    .Rows[dataGridView_Tasks.CurrentCell.RowIndex]
                    .Cells["TaskId"].Value.ToString();

            dataGrid_Tasks_Select(sender, e);
        }

        private void dataGridView_Empl_SelectionChanged(object sender, EventArgs e)
        {
            textBox_EmplId.Text = dataGridView_Empl
                    .Rows[dataGridView_Empl.CurrentCell.RowIndex]
                    .Cells["EmplId"].Value.ToString();

            dataGrid_Empl_Select(sender, e);
        }

        public void RefreshTasks() => Task_Add(null, null);
        public void RefreshEmployees() => Empl_Add(null, null);
    }
}
