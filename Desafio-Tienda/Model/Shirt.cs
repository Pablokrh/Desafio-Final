using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Shirt:Clothing
    {
        private string sleeve;
        private string collar;
        public string Sleeve { get => sleeve; }
        public string Collar { get => collar; }

        public Shirt(string sleeve, string collar, int quantityInStock, string quality, float unitPrice) : base(quantityInStock, quality, unitPrice) 
        {
            this.sleeve = sleeve;
            this.collar = collar;
            this.unitPrice = unitPrice;
            GetPrice();
        }

        public override void GetPrice()
        {
            if (sleeve == "Short") unitPrice = unitPrice- unitPrice* 10 / 100;
            if (collar == "Mao") unitPrice = unitPrice + unitPrice* 3 / 100;
            base.GetPrice();           
        }
    }  
}
