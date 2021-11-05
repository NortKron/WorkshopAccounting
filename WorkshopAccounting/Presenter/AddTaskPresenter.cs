using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WorkshopAccounting.Model;

namespace WorkshopAccounting.Presenter
{
    class AddTaskPresenter
    {
        ITaskAdd _view;
        IMainForm _viewMain;

        private DataDBContext _context;

        public Dictionary<int, string> listState;
        public Dictionary<int, string> listEmployees;

        public AddTaskPresenter(ITaskAdd view, IMainForm viewMain)
        {
            _view = view;
            _viewMain = viewMain;

            _context = new DataDBContext();

            listState = _context.TaskStates.ToDictionary(k => k.StateId, v => v.State);
            listEmployees = _context.Employees.ToDictionary(k => k.EmplId, v => v.Employee);

            _view.DataSource_ListEmployees = listState.Values.ToList();
            _view.DataSource_ListStates = listEmployees.Values.ToList();

            _view.Task_Add += new EventHandler(Task_Add);
        }

        public void Task_Add(object sender, EventArgs args)
        {
            Tasks task = new Tasks                
            {
                Name = _view.Task_Name,
                Descriptioin = _view.Task_Description,
                DateTime_Start = _view.Task_StartDate,
                DateTime_End = (_view.Task_EndDate_b ? _view.Task_EndDate : null),
                Spent_Hours = (_view.Task_Hours.Length > 0 ? Int32.Parse(_view.Task_Hours) : null),
                State = listState.FirstOrDefault(x => x.Value == _view.Task_State).Key,
                Employee = listEmployees.FirstOrDefault(x => x.Value == _view.Task_Employee).Key,
                Workshop = _view.Task_Workshop
            };

            _context.Tasks.Add(task);
            _context.SaveChanges();

            _viewMain.RefreshTasks();
        }
    }
}
