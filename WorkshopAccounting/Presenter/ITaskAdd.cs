using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAccounting.Presenter
{
    public interface ITaskAdd
    {
        string Task_Name { get; set; }
        string Task_Description { get; set; }
        DateTime Task_StartDate { get; set; }
        bool Task_EndDate_b { get; set; }
        DateTime Task_EndDate { get; set; }
        string Task_Hours { get; set; }
        string Task_State { get; set; }
        string Task_Employee { get; set; }
        int Task_Workshop { get; set; }

        Object DataSource_ListEmployees { set; }
        Object DataSource_ListStates { set; }

        event EventHandler Task_Add;
    }
}
