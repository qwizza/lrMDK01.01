using DemoLib;
using DemoLib.Views;
using System.Windows.Forms;

namespace DemoUIComponents
{
    public partial class ProductCard: UserControl, IProductsView
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public void Show(Product product)
        {
            CategoryLabel.Text = product.Category;
            CountLabel.Text = product.Count.ToString();
            PartsLabel.Text = product.Parts;
            PriceProductLabel.Text = product.Price.ToString();
            SupplierLabel.Text = product.Supplier.ToString() + " |";
            NameLabel.Text = product.Name.ToString();
            ImagePictureBox.ImageLocation = product.ImagePath;

        }

     
    }
}
