using System.Configuration;
using System.Data;
using System.Windows;
using ToDoList.Core;
using ToDoList.Database;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var database = new ToDoListDbContext();

            database.Database.EnsureCreated(); // upewnia sie czy baza jest stworzona jak nie to ja tworzy na nowo

            DataBaseLocator.Database = database;
        }
    }

}
