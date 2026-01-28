using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danucite360.Domain.Entities
{
    public class TaxExpenditure
    {
        public int Id { get; private set; }

        public int Year { get; private set; }
        public decimal Amount { get; private set; }

        public TaxType TaxType { get; private set; }
        public MeasureType MeasureType { get; private set; }
        public Goal Goal { get; private set; }
        public Sector Sector { get; private set; }
        public Recipient Recipient { get; private set; }

        protected TaxExpenditure() { }

        public TaxExpenditure(
            int year,
            decimal amount,
            TaxType taxType,
            MeasureType measureType,
            Goal goal,
            Sector sector,
            Recipient recipient)
        {
            Year = year;
            Amount = amount;
            TaxType = taxType;
            MeasureType = measureType;
            Goal = goal;
            Sector = sector;
            Recipient = recipient;
        }
    }

}
