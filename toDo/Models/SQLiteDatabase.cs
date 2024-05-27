using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;

namespace toDo.Models
{
    public class SQLiteDatabase
    {
        private readonly SQLiteConnection connection;

        public SQLiteDatabase(string dbPath)
        {
            connection = new SQLiteConnection(dbPath);
            connection.CreateTable<Tarea>();
        }

        public void AddTask(Tarea task)
        {
            connection.Insert(task);
        }

        public List<Tarea> GetTasks()
        {
            return connection.Table<Tarea>().ToList();
        }

        public Tarea GetTask(int id)
        {
            return connection.Table<Tarea>().Where(x => x.Id == id).FirstOrDefault();
        }

        public void UpdateTask(Tarea task)
        {
            connection.Update(task);
        }

        public void DeleteTask(int id)
        {
            connection.Delete<Tarea>(id);
        }
    }
}
