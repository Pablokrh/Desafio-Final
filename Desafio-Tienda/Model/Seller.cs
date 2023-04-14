using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Model
{
    public class Seller
    {
        private string name;
        private string surname;
        private int idSeller;
        private Quote quote;
        private List<Quote> quoteHistory;

        public Seller(string name, string surname, int idSeller)
        {
            this.name = name;
            this.surname = surname;
            this.idSeller = idSeller;
            quoteHistory = new List<Quote>();
        }
        public string Name { get => name; }
        public string Surname { get => surname; }
        public int IdSeller { get => idSeller; }
        public List<Quote> QuoteHistory { get => quoteHistory; }



        public int ShowUnitsAndPrice(string var1, string var2, string var3, out float messagePrice, ArrayList clothesList)
        {
            messagePrice = 0;
            int intToShow = 0;
            foreach (Object item in clothesList)
            {
                Type tipo = item.GetType();
                switch (tipo.Name)
                {
                    case "Pants":
                        Pants pants = (Pants)item;
                        if (pants.Fit == var1 && pants.Quality == var2)
                        {
                            intToShow = pants.QuantityInStock;
                            messagePrice = pants.UnitPrice;
                        }
                        break;

                    case "Shirt":
                        Shirt shirt = (Shirt)item;
                        if (shirt.Sleeve == var1 && shirt.Collar == var2 && shirt.Quality == var3)
                        {
                            intToShow = shirt.QuantityInStock;
                            messagePrice = shirt.UnitPrice;

                        }
                        break;

                    default:
                        break;
                }
            }
            return intToShow;
        }

        public void ShowNameAndId(ref string sellerName, ref string sellerSurName, ref string code)
        {
            sellerName = name;
            sellerSurName = surname;
            code = idSeller.ToString();
        }

        public Quote ShowQuoteHistory()
        {
            return quote;
            
            
        }

        public string Quote(int quantity, string var1, string var2, string var3, ArrayList clothesList, out float showQuote)
        {
            string message = "No hay stock disponible para realizar la cotización indicada";
            showQuote = 0;
            List<string> stringsDeLista = new List<string>();
            foreach (Object item in clothesList)
            {
                Type tipo = item.GetType();
                switch (tipo.Name)
                {
                    case "Pants":
                        Pants pants = (Pants)item;
                        if (var1 == pants.Fit && var2 == pants.Quality && pants.QuantityInStock >= quantity)
                        {
                            showQuote = pants.UnitPrice * quantity;
                            pants.CheckQuantity(quantity);
                            message= "";
                            quote = new Quote(idSeller, ("Pantalón " + pants.Fit + ". " + pants.Quality), quantity, showQuote);
                            quoteHistory.Add(quote);

                        }
                        break;
                        
                    case "Shirt":
                        Shirt shirt = (Shirt)item;
                        if (var1 == shirt.Sleeve && var2== shirt.Collar && var3 == shirt.Quality && shirt.QuantityInStock >= quantity)
                        {
                            showQuote = shirt.UnitPrice * quantity;
                            shirt.CheckQuantity(quantity);
                            message = "";
                            quote = new Quote(idSeller, ("Camisa " + shirt.Sleeve + ". " + shirt.Collar + ". " + shirt.Quality), quantity, showQuote);
                            quoteHistory.Add(quote);
                        }
                        break;
                    default:
                        break;     
                }

            }
            return message;

        }
        

    }
        

}
