using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pants:Clothing
    {
        private string fit;
        public string Fit { get => fit; }      

        public Pants (string fit, int quantityInStock, string quality, float unitPrice) :base (quantityInStock, quality, unitPrice)
        {
            this.fit = fit;
            this.unitPrice = unitPrice;
            GetPrice();
        }

        public override void GetPrice()
        {
            if (fit == "Skinny") unitPrice -= unitPrice* 12 / 100;
            base.GetPrice();
        }


    }
}
