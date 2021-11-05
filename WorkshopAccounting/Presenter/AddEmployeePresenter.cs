using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WorkshopAccounting.Model;

namespace WorkshopAccounting.Presenter
{
    class AddEmployeePresenter
    {
        private DataDBContext _context;

        IMainForm _viewMain;
        IEmplAdd _view;

        public AddEmployeePresenter(IEmplAdd view, IMainForm viewMain)
        {
            _view = view;
            _viewMain = viewMain;

            _context = new DataDBContext();
            _view.Employee_Add += new EventHandler(Employee_Add);
        }

        public void Employee_Add(object sender, EventArgs args)
        {
            _context.Employees.Add(
                new Employees
                {
                    Employee = _view.Employee_Name,
                    Position = _view.Employee_Position,
                    Empl_Date = _view.Employee_Date,
                });
            _context.SaveChanges();

            _viewMain.RefreshEmployees();
        }
    }
}
