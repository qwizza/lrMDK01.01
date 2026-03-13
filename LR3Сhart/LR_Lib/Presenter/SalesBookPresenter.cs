using LR_Lib.Model;
using LR_Lib.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Lib.Presenter
{
    public class SalesBookPresenter
    {
        private SalesBookModel model_ = new SalesBookModel();
        private IBookSalesView view_;

        public SalesBookPresenter(IBookSalesView view)
        {
            view_ = view;
            model_.Load();

            ShowAllGenres();
            ShowTotalProfit();
        }

        public void ShowSalesByGenre(string genreName)
        {
            List<Sale> sales = model_.LoadSalesForItem(genreName);
            view_.ShowSalesForGenre(sales, genreName);

            double profit = GetGenreProfit(genreName);
            view_.ShowGenreProfit(genreName, profit);
        }

        public List<string> GetAllGenres()
        {
            return model_.GetAllGenres();
        }

        public void ShowAllGenres()
        {
            List<string> genres = GetAllGenres();
            view_.ShowGenres(genres);
        }

        public void ShowTotalProfit()
        {
            double totalProfit = model_.GetTotalRevenue();
            view_.ShowTotalProfit(totalProfit);
        }

        public double GetGenreProfit(string genreName)
        {
            return model_.GetProfitByGenre(genreName);
        }

        public int[] GetSalesForLast7Days(string genreName)
        {
            return model_.GetSalesForLast7Days(genreName);
        }
    }
}

