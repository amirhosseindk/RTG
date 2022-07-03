using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DB
{
    public class ConnectionStrings : Object
    {
        public ConnectionStrings() : base()
        {
        }

        public string MyConnectionString { get; set; }
    }
}
