using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WorkshopAccounting.Model;

namespace WorkshopAccounting.Presenter
{
    class MainPresenter
    {
        private DataDBContext _context;

        public Dictionary<int, string> listState;
        public Dictionary<int, string> listEmployees;

        private readonly IMainForm _view;

        public MainPresenter(IMainForm view)
        {
            _view = view;
            _context = new DataDBContext();

            LoadTasks();
            _view.DataSource_Employees = _context.Employees.ToList();

            listState = _context.TaskStates.ToDictionary(k => k.StateId, v => v.State);
            listEmployees = _context.Employees.ToDictionary(k => k.EmplId, v => v.Employee);

            _view.DataSource_ListEmployees = listState.Values.ToList();
            _view.DataSource_ListStates = listEmployees.Values.ToList();

            _view.dataGrid_Tasks_Select += new EventHandler(Task_Select);
            _view.Task_Save += new EventHandler(Task_Save);
            _view.Task_Delete += new EventHandler(Task_Delete);
            _view.Task_Add += new EventHandler(Task_Add);


            _view.dataGrid_Empl_Select += new EventHandler(Employee_Select);
            _view.Empl_Save += new EventHandler(Employee_Save);
            _view.Empl_Delete += new EventHandler(Employee_Delete);
            _view.Empl_Add += new EventHandler(Employee_Add);
        }

        public void LoadTasks()
        {
            var request = from task in _context.Tasks
                          from employee in _context.Employees
                          from state in _context.TaskStates
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

            _view.DataSource_Tasks = request.ToList();
        }

        public void Task_Save(object sender, EventArgs args)
        {
            Tasks task = _context.Tasks
                    .FirstOrDefault(x => x.TaskId == _view.Task_Id);

            if (task != null)
            {
                task.Name = _view.Task_Name;
                task.Descriptioin = _view.Task_Description;
                task.DateTime_Start = _view.Task_StartDate;
                task.DateTime_End = (_view.Task_EndDate_b ? _view.Task_EndDate : null);
                task.Spent_Hours = (_view.Task_Hours.Length > 0 ? Int32.Parse(_view.Task_Hours) : null);
                task.State = listState.FirstOrDefault(x => x.Value == _view.Task_State).Key;
                task.Employee = listEmployees.FirstOrDefault(x => x.Value == _view.Task_Employee).Key;
                task.Workshop = _view.Task_Workshop;

                _context.SaveChanges();
                LoadTasks();
            }
        }

        public void Task_Delete(object sender, EventArgs args)
        {
            Tasks task = _context.Tasks.FirstOrDefault(x => x.TaskId == _view.Task_Id);

            try
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();

                LoadTasks();
                _view.Status_Label = "Данные по задаче удалены из базы данных";
            }
            catch (Exception e)
            {
                _view.Status_Label = "Не удалось удалить задачу";
            }
        }

        public void Task_Add(object sender, EventArgs args)
        {
            LoadTasks();
            _view.Status_Label = "Новая задача добавлена в базу данных";
        }

        public void Task_Select(object sender, EventArgs args)
        {
            Tasks task = _context.Tasks
                    .FirstOrDefault(x => x.TaskId == _view.Task_Id);

            if (task != null)
            {
                _view.Task_Name = task.Name;
                _view.Task_Description = task.Descriptioin;
                _view.Task_StartDate = task.DateTime_Start;

                _view.Task_EndDate_b = (task.DateTime_End != null);
                _view.Task_EndDate = (task.DateTime_End == null
                    ? task.DateTime_Start
                    : task.DateTime_End.Value);

                _view.Task_Hours = task.Spent_Hours.ToString();

                _view.Task_State = listState[task.State];
                _view.Task_Employee = listEmployees[task.Employee];
                _view.Task_Workshop = task.Workshop;
            }
        }

        public void Employee_Save(object sender, EventArgs args)
        {
            Employees employee = _context.Employees.FirstOrDefault(x => x.EmplId == _view.Employee_Id);

            employee.Employee = _view.Employee_Name;
            employee.Position = _view.Employee_Position;
            employee.Empl_Date = _view.Employee_Date;
            _context.SaveChanges();

            _view.DataSource_Employees = _context.Employees.ToList();
            _view.Status_Label = "Изменения по сотруднику сохранены";
        }

        public void Employee_Delete(object sender, EventArgs args)
        {
            Employees employee = _context.Employees.FirstOrDefault(x => x.EmplId == _view.Employee_Id);

            try
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();

                _view.DataSource_Employees = _context.Employees.ToList();
                _view.Status_Label = "Данные о сотруднике удалены из базы данных";
            }
            catch (Exception e)
            {
                _view.Status_Label = "Не удалось удалить сотрудника";
            }
        }

        public void Employee_Select(object sender, EventArgs args)
        {
            Employees employee = _context.Employees
                    .FirstOrDefault(x => x.EmplId == _view.Employee_Id);

            if (employee != null)
            {
                _view.Employee_Name = employee.Employee;
                _view.Employee_Position = employee.Position;
                _view.Employee_Date = employee.Empl_Date;

                _view.DataSource_EmplTasks = _context.Tasks.Where(x => x.Employee == _view.Employee_Id).ToList();
            }
        }

        public void AddTasks(Tasks taskNew)
        {
            _context.Tasks.Add(taskNew);
            _context.SaveChanges();
            _view.Status_Label = "Новая задача добавлена в базу данных";
        }

        public void Employee_Add(object sender, EventArgs args)
        {
            _view.DataSource_Employees = _context.Employees.ToList();
            _view.Status_Label = "Новый сотрудник добавлен в базу данных";
        }
    }
}
