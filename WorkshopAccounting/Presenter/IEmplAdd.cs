using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAccounting.Presenter
{
    public interface IEmplAdd
    {
        string Employee_Name { get; set; }
        string Employee_Position { get; set; }
        DateTime Employee_Date { get; set; }

        event EventHandler Employee_Add;
    }
}
