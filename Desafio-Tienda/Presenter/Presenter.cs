using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class Presenter
    {
        private IView _View;
        Model.Store store;
        Model.Seller seller;

        public Presenter(IView _View)
        {
            this._View = _View;        
            seller = new Model.Seller("Pablo", "Krojzl", 026);
            store = new Model.Store();           
        }

        public void Quote(int quantity, string var1, string var2, string var3)
        {
            string aux = seller.Quote(quantity, var1, var2, var3, store.ClothesList, out float showQuote);
            _View.ShowMessageAlert(aux);
            _View.ShowQuote(showQuote);
            if (aux == "") _View.ShowQuoteHistory(seller.ShowQuoteHistory().ClothingQuote, seller.ShowQuoteHistory().Id, seller.ShowQuoteHistory().IdSeller, seller.ShowQuoteHistory().DayHour, seller.ShowQuoteHistory().Units, seller.ShowQuoteHistory().FinalQuote);
        }

        public void ShowNameAndId()
        {
            string sellerName="";
            string code="";
            string sellerSurName = "";
            seller.ShowNameAndId(ref sellerName, ref sellerSurName, ref code);
            _View.ShowNameAndId(sellerName, sellerSurName, code);
        }

        public void ShowUnitsAndPrice(string var1, string var2, string var3)
        {
            _View.ShowUnits(seller.ShowUnitsAndPrice(var1, var2, var3, out float messagePrice, store.ClothesList));
            _View.ShowPrice(messagePrice);
        }


    }
}
