using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBulkCopyDemo
{
    public class Entities : DbContext
    {
        public Entities(string nameOrConnectionString = "Entities")
            : base(nameOrConnectionString)
        {

        }
    }
}
