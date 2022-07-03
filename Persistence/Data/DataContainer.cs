using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data
{
    public static class DataContainer : Object
    {
        static DataContainer()
        {

        }

        public static Domain.User user { get; set; }

        public static DateTime now { get; set; }


    }
}
