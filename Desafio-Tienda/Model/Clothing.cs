using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   abstract public class Clothing
   {
        protected int quantityInStock;
        protected string quality;
        protected float unitPrice;

        public string Quality { get => quality; }
        public float UnitPrice { get => unitPrice; }
        public int QuantityInStock { get => quantityInStock; }

        public Clothing(int quantityInStock, string quality, float unitPrice)
        {
            this.quantityInStock = quantityInStock;
            this.quality = quality;
            this.unitPrice = unitPrice;
        }

        public virtual void GetPrice()
        {
            if (quality == "Premium") unitPrice =unitPrice*130/100;           
        }

        public int CheckQuantity(int selectedQuantity)
        {
            if (quantityInStock >= selectedQuantity) quantityInStock -= selectedQuantity;
            return quantityInStock;
        }


       
   }
}
