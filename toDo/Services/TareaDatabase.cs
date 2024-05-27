using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using toDo.Models;

namespace toDo.Services
{
    public class TareaDatabase
    {
        readonly SQLiteAsyncConnection database;

        public TareaDatabase(string dbPath)
        {
            try
            {
                database = new SQLiteAsyncConnection(dbPath);
                database.CreateTableAsync<Tarea>().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al inicializar la base de datos: {ex}");
                throw;
            }
        }

        public Task<List<Tarea>> GetTareasAsync()
        {
            return database.Table<Tarea>().ToListAsync();
        }

        public Task<int> SaveTareaAsync(Tarea tarea)
        {
            if (tarea.Id != 0)
            {
                return database.UpdateAsync(tarea);
            }
            else
            {
                return database.InsertAsync(tarea);
            }
        }

        public Task<int> DeleteTareaAsync(Tarea tarea)
        {
            return database.DeleteAsync(tarea);
        }
    }
}
