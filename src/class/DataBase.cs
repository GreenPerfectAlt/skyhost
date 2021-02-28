using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace skyhost
{
    class DataBase : DbContext
    {
        
        public DbSet<Daily> Dailys { get;set; }

        public DataBase() : base("DefaultConnection") { }
    }
}
