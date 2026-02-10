using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LR3
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Dishs>> dishes_ = new Dictionary<string, List<Dishs>>();
        private Dictionary<string, int> orderItems_ = new Dictionary<string, int>();
        private FileDishStorage fileDishStorage = new FileDishStorage();

        public MainForm()
        {
            InitializeComponent();


            MenuListBox.SelectedIndexChanged += CategoriesListBox_SelectedIndexChanged;
            Group_dishesСomboBox.SelectedIndexChanged += DishesComboBox_SelectedIndexChanged;
            btnAddToOrder.Click += AddToOrderButton_Click;
            btnClearOrder.Click += ClearOrderButton_Click;
            btnPlaceOrder.Click += PlaceOrderButton_Click;

            dishes_ = fileDishStorage.LoadDataFromCsv();
            List<string> allCategories = dishes_.Keys.ToList();
            MenuListBox.DataSource = allCategories;
        }

        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = MenuListBox.SelectedItem.ToString();
            List<Dishs> dishesInCategory = dishes_[selectedCategory];
            Group_dishesСomboBox.DataSource = dishesInCategory;
            Group_dishesСomboBox.DisplayMember = "Name";
        }

        private void DishesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dishs selectedDish = Group_dishesСomboBox.SelectedItem as Dishs;
            if (selectedDish != null)
            {
                labelDishName.Text = selectedDish.Name;
                labelPrice.Text = selectedDish.Price + " руб.";
                labelDescription.Text = selectedDish.Description;
                labelIngredients.Text = selectedDish.Ingredients;
                pictureDish.Load(selectedDish.ImagePath);
            }
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            Dishs selectedDish = Group_dishesСomboBox.SelectedItem as Dishs;
            if (selectedDish != null)
            {
                string dishName = selectedDish.Name;
                int quantity = (int)numericUpDownQuantity.Value;

                if (orderItems_.ContainsKey(dishName))
                {
                    orderItems_[dishName] += quantity;
                }
                else
                {
                    orderItems_[dishName] = quantity;
                }

                UpdateOrderDisplay();
                ShowOrderConfirmation(dishName, quantity);
            }
        }

        private void UpdateOrderDisplay()
        {
            string orderText = "Ваш заказ:\n\n";
            int totalPrice = 0;

            foreach (var item in orderItems_)
            {
                Dishs dish = null;
                foreach (var category in dishes_.Values)
                {
                    dish = category.FirstOrDefault(d => d.Name == item.Key);
                    if (dish != null) break;
                }

                if (dish != null)
                {
                    int itemTotal = int.Parse(dish.Price.Replace(" руб.", "")) * item.Value;
                    totalPrice += itemTotal;
                    orderText += $"{item.Key}: {item.Value} шт. - {itemTotal} руб.\n";
                }
            }

            orderText += $"\nИтого: {totalPrice} руб.";
            textBoxOrder.Text = orderText;
        }

        private void ShowOrderConfirmation(string dishName, int quantity)
        {
            MessageBox.Show($"Добавлено: {dishName} x{quantity}\nПродолжайте выбирать блюда!",
                "Добавлено в заказ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            if (orderItems_.Count == 0)
            {
                MessageBox.Show("Заказ пуст! Добавьте блюда.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string orderSummary = "Ваш заказ оформлен!\n\n";
            decimal totalPrice = 0;

            foreach (var item in orderItems_)
            {
                Dishs dish = null;
                foreach (var category in dishes_.Values)
                {
                    dish = category.FirstOrDefault(d => d.Name == item.Key);
                    if (dish != null) break;
                }

                if (dish != null)
                {
                    decimal itemTotal = int.Parse(dish.Price.Replace(" руб.", "")) * item.Value;
                    totalPrice += itemTotal;
                    orderSummary += $"{item.Key}: {item.Value} шт. - {itemTotal} руб.\n";
                }
            }

            orderSummary += $"\nОбщая стоимость: {totalPrice} руб.";
            orderSummary += "\n\nСпасибо за заказ! Приятного аппетита!";

            MessageBox.Show(orderSummary, "Заказ оформлен",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearOrder();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }

        private void ClearOrder()
        {
            orderItems_.Clear();
            textBoxOrder.Clear();
            numericUpDownQuantity.Value = 1;
            MessageBox.Show("Заказ очищен", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}