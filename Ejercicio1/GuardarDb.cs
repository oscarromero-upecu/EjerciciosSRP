using System.Data.Entity;

namespace EjerciciosSRP.Ejercicio1
{
    internal class GuardarDb
    {
        private readonly DbContext _db;

        public GuardarDb(DbContext db)
        {
            _db = db;
        }

        public void GuardarEnDb()
        {
            // Guardar en BDD
        }
    }
}

