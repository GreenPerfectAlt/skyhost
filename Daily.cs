using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyhost
{
    class Daily
    {

        public int id { get; set; }
        public string time;
        public Daily() { }

        public Daily(int id, string time){
            this.id = id;
            this.time = time;
        }
    }
}
