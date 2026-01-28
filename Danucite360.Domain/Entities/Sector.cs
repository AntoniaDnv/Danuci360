using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danucite360.Domain.Entities
{
    public class Sector
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        protected Sector() { }

        public Sector(string name)
        {
            Name = name;
        }
    }
}
