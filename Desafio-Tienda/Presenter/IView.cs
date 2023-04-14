using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IView
    {
        void ShowMessageAlert(string message);

        void ShowUnits(int intToShow);

        void ShowPrice(float unitPrice);

        void ShowQuote(float showQuote);

        void ShowQuoteHistory(string clothingQuote, int id, int idSeller, DateTime hourAndDate, int units, float finalPrice);

        void ShowNameAndId(string sellerName, string sellerSurName, string code);
    }
}
