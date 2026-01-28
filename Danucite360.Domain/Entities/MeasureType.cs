using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danucite360.Domain.Entities
{
    public class MeasureType
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        protected MeasureType() { }

        public MeasureType(string name) 
        {
            Name = name;
        }
    }
}
