using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danucite360.Domain.Entities
{
    public class TaxType
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        protected TaxType() { }

        public TaxType(string name)
        {
            Name = name;
        }
    }

}
