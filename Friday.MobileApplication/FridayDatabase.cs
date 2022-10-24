using Friday.MobileApplication.Data.Entity;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday.MobileApplication
{
    public class FridayDatabase
    {
        SQLiteAsyncConnection Database;

        public FridayDatabase()
        {
        }

        public async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            await Database.CreateTableAsync<LoginData>();
        }

        public async Task<LoginData> GetLoginDataAsync()
        {
            await Init();
            return await Database.Table<LoginData>().FirstOrDefaultAsync();
        }

        public async Task SaveItem(LoginData item)
        {
            await Init();
            var exist = await Database.Table<LoginData>().FirstOrDefaultAsync();
            if (exist != null)
            {
                await Database.UpdateAsync(item);
            }
            else
            {
                await Database.InsertAsync(item);
            }
        }
    }
}
