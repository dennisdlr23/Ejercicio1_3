using Ejercicio1_3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_3.Controllers
{
    public class PersonasController
    {
        readonly SQLiteAsyncConnection _connection;
        public PersonasController(string dbpath)
        {
            _connection = new SQLiteAsyncConnection(dbpath);
            _connection.CreateTableAsync<Personas>().Wait();
        }

        //CRUD - create - delete - update - read

        //Create
        public Task<int> StorePersonas(Personas persona)
        {
            if (persona.id != 0)
            {
                return _connection.UpdateAsync(persona);
            }
            else
            {
                return _connection.InsertAsync(persona);
            }
        }

        public Task<List<Personas>> ListaPersonas()
        {
            return _connection.Table<Personas>().ToListAsync();
        }
        public Task<Personas> ObtenerPersonas(int pid)
        {
            return _connection.Table<Personas>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }

        public Task<int> DeletePersonas(Personas persona)
        {
            return _connection.DeleteAsync(persona);
        }
    }
}
