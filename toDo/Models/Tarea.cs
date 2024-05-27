using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace toDo.Models
{
    public class Tarea
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
