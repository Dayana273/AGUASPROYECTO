using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AGUASPROYECTO.CONTROLLERS
{
    class AguasHondurasControllers
    {
        readonly SQLiteAsyncConnection _Connection;
        public AguasHondurasControllers(string DBPath)
        {
            _Connection = new SQLiteAsyncConnection(DBPath);
            _Connection.CreateTableAsync<MODELS.AGUAH>();

        }
        public Task<int> SaveAguas(MODELS.AGUAH posicion)
        {
            if (posicion.id != 0)
                return _Connection.UpdateAsync(posicion);
            else
                return _Connection.InsertAsync(posicion);
        }

        // READ one
        public Task<MODELS.AGUAH> GetAguasHonduras(int pid)
        {
            return _Connection.Table<MODELS.AGUAH>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }
        public Task<List<MODELS.AGUAH>> GetListAguas()
        {
            return _Connection.Table<MODELS.AGUAH>().ToListAsync();
        }

    }




}

