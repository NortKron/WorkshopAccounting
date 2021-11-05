using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAccounting.Presenter
{
    public interface IMainForm
    {
        int Task_Id { get; set; }
        string Task_Name { get; set; }
        string Task_Description{ get; set; }
        DateTime Task_StartDate { get; set; }
        bool Task_EndDate_b { get; set; }
        DateTime Task_EndDate { get; set; }
        string Task_Hours { get; set; }
        string Task_State { get; set; }
        string Task_Employee { get; set; }
        int Task_Workshop { get; set; }

        int Employee_Id { get; set; }
        string Employee_Name { get; set; }
        string Employee_Position { get; set; }
        DateTime Employee_Date { get; set; }

        string Status_Label { get; set; }

        #region DataSources
        Object DataSource_Tasks { set; }
        Object DataSource_Employees { set; }
        Object DataSource_EmplTasks { set; }
        Object DataSource_ListEmployees { set; }
        Object DataSource_ListStates { set; }

        #endregion DataSources

        void RefreshEmployees();
        void RefreshTasks();

        #region Events

        event EventHandler dataGrid_Tasks_Select;
        event EventHandler dataGrid_Empl_Select;

        event EventHandler Task_Add;
        event EventHandler Task_Save;
        event EventHandler Task_Delete;

        event EventHandler Empl_Add;
        event EventHandler Empl_Save;
        event EventHandler Empl_Delete;

        #endregion Events

    }
}
