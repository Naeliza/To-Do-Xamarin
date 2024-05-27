using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using toDo.Models;

namespace toDo.Services
{
    public class TareaDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public TareaDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Tarea>().Wait();
        }

        public Task<List<Tarea>> GetTareasAsync()
        {
            return _database.Table<Tarea>().ToListAsync();
        }

        public Task<Tarea> GetTareaAsync(int id)
        {
            return _database.Table<Tarea>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveTareaAsync(Tarea tarea)
        {
            if (tarea.Id != 0)
            {
                return _database.UpdateAsync(tarea);
            }
            else
            {
                return _database.InsertAsync(tarea);
            }
        }

        public Task<int> DeleteTareaAsync(Tarea tarea)
        {
            return _database.DeleteAsync(tarea);
        }
    }
}
