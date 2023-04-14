using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    public class Quote
    {
        private int id;
        private DateTime dayHour;
        private int idSeller;
        private string clothingQuote;
        private int units;
        private float finalQuote;
        static private int generateId = 0;

        public int Id { get => id;}
        public DateTime DayHour { get => dayHour;  }
        public int IdSeller { get => idSeller; }
        public string ClothingQuote { get => clothingQuote;  }
        public int Units { get => units; }
        public float FinalQuote { get => finalQuote; }

        public Quote (int idSeller, string clothingQuote, int units, float finalQuote)
        {
            this.idSeller = idSeller;
            this.clothingQuote = clothingQuote;
            this.units = units;
            this.finalQuote = finalQuote;
            dayHour = DateTime.Now;
            id= GenerateId();           
        }

        private int GenerateId()
        {
            id = Interlocked.Increment(ref generateId);
            return id;
        }
    }
}
