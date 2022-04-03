using System;
using System.Data.Entity;
using System.IO;

namespace EjerciciosSRP.Ejercicio2
{
    class LogeoError
    {
        private readonly DbContext _db;

        public LogeoError(DbContext db)
        {
            _db = db;
        }

        public void LogError(Exception ex)
        {
            _db.LogError("Error:", ex.ToString());
            File.WriteAllText("Log.txt", ex.ToString());
        }

    }
}
