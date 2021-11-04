using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

using WorkshopAccounting.Presenter;
using WorkshopAccounting.Model;

namespace WorkshopAccounting.View
{
    public partial class MainForm : Form, IMainForm
    {
        DataDBContext _context;
        DbSet<Tasks> _tasks;
        DbSet<Employees> _employees;
        DbSet<TaskStates> _states;

        public Dictionary<int, string> listState;
        public Dictionary<int, string> listEmployees;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _context = new DataDBContext();

            //var connectionString = ConfigurationManager.ConnectionStrings["Production"].ConnectionString;            
            //MessageBox.Show(">> " + connectionString, "Заголовок информационного сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information); 

            //context.Employees.Select(x => x);

            _tasks = _context.Tasks;
            _employees = _context.Employees;
            _states = _context.TaskStates;

            var request = from task in _tasks
                          from employee in _employees
                          from state in _states
                          where task.Employee == employee.EmplId
                              && task.State == state.StateId
                          select new
                          {
                              task.TaskId,
                              task.Name,
                              task.Descriptioin,
                              task.DateTime_Start,
                              task.DateTime_End,
                              task.Spent_Hours,
                              state.State,
                              employee.Employee,
                              task.Workshop
                          };

            dataGridView_Tasks.DataSource = request.ToList();
            dataGridView_Empl.DataSource = _employees.Select(x => x).ToList();

            listState = _states.ToDictionary(k => k.StateId, v => v.State);
            comboBox_State.DataSource = listState.Values.ToList();

            listEmployees = _employees.ToDictionary(k => k.EmplId, v => v.Employee);
            comboBox_Employee.DataSource = listEmployees.Values.ToList();

            ToolStripButtonRefresh();
        }

        //private IQueryable<A> request() => 

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

        private void dataGridView_Empl_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Index : " + dataGridView_Empl.row );
            //dataGridView_Empl_CellClick(sender, e);
        }

        private void dataGridView_Empl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_EmplId.Text = dataGridView_Empl.CurrentRow.Cells["EmplId"].Value.ToString();
            textBox_Employee.Text = dataGridView_Empl.CurrentRow.Cells["Employee"].Value.ToString();
            textBox_Position.Text = dataGridView_Empl.CurrentRow.Cells["Position"].Value.ToString();
            dateTimePicker_Employ.Value = (DateTime)dataGridView_Empl.CurrentRow.Cells["Empl_Date"].Value;

            dataGridView_EmplTasks.DataSource = _context.Tasks
                .Where(x => x.Employee == (int)dataGridView_Empl.CurrentRow.Cells["EmplId"].Value).ToList();

        }

        private void button_EmplSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(">> " + dateTimePicker_Employ.Value);

            Employees employee = _context.Employees.FirstOrDefault(x => x.EmplId == (int)dataGridView_Empl.CurrentRow.Cells["EmplId"].Value);

            employee.Employee = textBox_Employee.Text;
            employee.Position = textBox_Position.Text;
            employee.Empl_Date = dateTimePicker_Employ.Value;
            _context.SaveChanges();

            dataGridView_Empl.DataSource = _context.Employees.Select(x => x).ToList();
            toolStripStatusLabel1.Text = "Изменения по сотруднику сохранены";
        }

        private void button_EmplDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить сотрудника?", "Удаление сотрудника",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Employees employee = _context.Employees
                    .FirstOrDefault(x => x.EmplId == (int)dataGridView_Empl.CurrentRow.Cells["EmplId"].Value);

                _context.Employees.Remove(employee);
                _context.SaveChanges();

                dataGridView_Empl.DataSource = _context.Employees.Select(x => x).ToList();
                toolStripStatusLabel1.Text = "Данные по сотруднику удалены из базы данных";

                textBox_EmplId.Clear();
                textBox_Employee.Clear();
                textBox_Position.Clear();
                dateTimePicker_Employ.ResetText();
                dataGridView_EmplTasks.DataSource = null;
            }
        }

        private void toolStripButton_SaveTask_Click(object sender, EventArgs e)
        {
            new Form_AddTask(this).ShowDialog();
        }

        private void toolStripButton_AddEmployee_Click(object sender, EventArgs e)
        {
            new Form_AddEmployee(this).ShowDialog();
        }

        private void Menu_Git_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_About_Click(object sender, EventArgs e) => new Form_About().ShowDialog();

        //public void AddEmployee(string Employee, string Position, DateTime EmplDate)
        public void AddEmployee(Employees employeeNew)
        {
            _context.Employees.Add(employeeNew);
            _context.SaveChanges();

            dataGridView_Empl.DataSource = _context.Employees.Select(x => x).ToList();
            toolStripStatusLabel1.Text = "Новый сотрудник добавлен в базу данных";
        }

        public void AddTasks(Tasks taskNew)
        {
            _context.Tasks.Add(taskNew);
            _context.SaveChanges();

            dataGridView_Tasks.DataSource = _context.Tasks.Select(x => x).ToList();
            toolStripStatusLabel1.Text = "Новая задача добавлена в базу данных";
        }

        private void dataGridView_Tasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_TaskId.Text = dataGridView_Tasks.CurrentRow.Cells["TaskId"].Value.ToString();
            textBox_TaskName.Text = dataGridView_Tasks.CurrentRow.Cells["Name"].Value.ToString();
            textBox_Description.Text = dataGridView_Tasks.CurrentRow.Cells["Descriptioin"].Value.ToString();

            dateTimePicker_Start.Value = (DateTime)dataGridView_Tasks.CurrentRow.Cells["DateTime_Start"].Value;
            dateTimePicker_End.Value = (dataGridView_Tasks.CurrentRow.Cells["DateTime_End"].Value == null ?
                (DateTime)dataGridView_Tasks.CurrentRow.Cells["DateTime_Start"].Value :
                (DateTime)dataGridView_Tasks.CurrentRow.Cells["DateTime_End"].Value);

            textBox_Hours.Text = (dataGridView_Tasks.CurrentRow.Cells["Spent_Hours"].Value == null ?
                "" : dataGridView_Tasks.CurrentRow.Cells["Spent_Hours"].Value.ToString());

            comboBox_State.Text = dataGridView_Tasks.CurrentRow.Cells["State"].Value.ToString();
            comboBox_Employee.Text = dataGridView_Tasks.CurrentRow.Cells["Employee"].Value.ToString();
            textBox_Workshop.Text = dataGridView_Tasks.CurrentRow.Cells["Workshop"].Value.ToString();
        }

        private void button_TaskDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить задачу?", "Удаление задачи",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Tasks task = _context.Tasks
                    .FirstOrDefault(x => x.TaskId == (int)dataGridView_Tasks.CurrentRow.Cells["TaskId"].Value);

                _context.Tasks.Remove(task);
                _context.SaveChanges();

                dataGridView_Tasks.DataSource = _context.Tasks.Select(x => x).ToList();
                toolStripStatusLabel1.Text = "Данные по задаче удалены из базы данных";

                textBox_TaskId.Clear();
                textBox_TaskName.Clear();
                textBox_Description.Clear();
                dateTimePicker_Start.ResetText();
                dateTimePicker_End.ResetText();
                textBox_Workshop.Clear();
            }
        }

        private void button_TaskSave_Click(object sender, EventArgs e)
        {
            Tasks tasks = _context.Tasks.FirstOrDefault(x => x.TaskId == (int)dataGridView_Tasks.CurrentRow.Cells["TaskId"].Value);

            tasks.Name = textBox_TaskName.Text;
            tasks.Descriptioin = textBox_Description.Text;
            tasks.DateTime_Start = dateTimePicker_Start.Value;
            tasks.DateTime_End =
                (
                    tasks.DateTime_End == null && dateTimePicker_Start.Value == dateTimePicker_End.Value
                    ? null
                    : dateTimePicker_End.Value
                );
            tasks.Spent_Hours =
                (
                    textBox_Hours.Text.Length == 0
                    ? null
                    : Int32.Parse(textBox_Hours.Text)
                );

            tasks.State = listState.ElementAt(comboBox_State.SelectedIndex).Key;
            tasks.Employee = listEmployees.ElementAt(comboBox_Employee.SelectedIndex).Key;
            tasks.Workshop = Int32.Parse(textBox_Workshop.Text);
            _context.SaveChanges();

            dataGridView_Tasks.Update();
            toolStripStatusLabel1.Text = "Изменения по задаче сохранены";
        }

        private void Menu_Tasks_Click(object sender, EventArgs e) => OpenTabWindow(0);
        private void Menu_Employees_Click(object sender, EventArgs e) => OpenTabWindow(1);
        private void OpenTabWindow(int tabIndex)
        {
            tabControl_Main.SelectedIndex = tabIndex;
            ToolStripButtonRefresh();
        }
    }
}
