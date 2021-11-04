using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAccounting.Model
{

    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }

        public string Name { get; set; }

        public string? Descriptioin { get; set; }

        public DateTime DateTime_Start { get; set; }

        public DateTime? DateTime_End { get; set; }

        public int? Spent_Hours { get; set; }

        public int State { get; set; }

        public int Employee { get; set; }

        public int Workshop { get; set; }

    }

    public class Employees
    {
        [Key]
        public int EmplId { get; set; }

        public string Employee { get; set; }

        public string Position { get; set; }

        public DateTime Empl_Date { get; set; }

    }

    public class TaskStates
    {
        [Key]
        public int StateId { get; set; }

        public string State { get; set; }

    }
}
