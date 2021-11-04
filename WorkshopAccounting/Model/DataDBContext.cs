using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using System.Diagnostics;

namespace WorkshopAccounting.Model
{
    public class DataDBContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<TaskStates> TaskStates { get; set; }

        public string connectionString { get; private set; }

        public DataDBContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);

            //connectionString = $"{path}{System.IO.Path.DirectorySeparatorChar}blogging.db";
            //connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=" + Environment.CurrentDirectory + "\\App_Data\\Production.mdf; Integrated Security=True";

            connectionString = ConfigurationManager
                .ConnectionStrings["Production"].ConnectionString
                .Replace("%CONTENTROOTPATH%", Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\")));

            Debug.Print(">> connectionString = " + connectionString);
        }

        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options) 
        { 

        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer(connectionString);
            options.UseSqlServer(connectionString);
        }

    }
}
