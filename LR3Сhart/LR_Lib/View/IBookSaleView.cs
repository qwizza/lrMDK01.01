using LR_Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Lib.View
{
    public interface IBookSalesView
    {
        void ShowGenres(List<string> genres);

        void ShowSalesForGenre(List<Sale> sales, string genreName);

        void ShowTotalProfit(double totalProfit);

        void ShowGenreProfit(string genreName, double profit);

        void ShowErrorMessage(string message);
    }
}
