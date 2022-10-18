using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday.MobileApplication.Data.Entity
{
    public class LoginData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public string UserEmail { get; set; }
        public bool IsSave { get; set; }
    }
}
