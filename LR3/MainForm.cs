using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LR3
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Dish>> dishes_ = new Dictionary<string, List<Dish>>();
        private Dictionary<string, int> orderItems_ = new Dictionary<string, int>();

        public MainForm()
        {
            InitializeComponent();


            MenuListBox.SelectedIndexChanged += CategoriesListBox_SelectedIndexChanged;
            Group_dishesСomboBox.SelectedIndexChanged += DishesComboBox_SelectedIndexChanged;
            btnAddToOrder.Click += AddToOrderButton_Click;
            btnClearOrder.Click += ClearOrderButton_Click;
            btnPlaceOrder.Click += PlaceOrderButton_Click;

           /* dishes_.Add("Супы",
            new List<Dish>() {
                    new Dish("Борщ", "Красный борщ со сметаной", 250, "Свекла, капуста, мясо, сметана", "C:\\reposit\\LR3\\soup\\borsch.jpg"),
                    new Dish("Куриный суп", "Легкий куриный суп", 200, "Курина, лапша, морковь, лук", "C:\\reposit\\LR3\\soup\\chicken_soup.jpg"),
                    new Dish("Солянка", "Густой мясной суп", 280, "Разные виды мяса, огурцы, оливки", "C:\\reposit\\LR3\\soup\\solyanka.jpg")  }
        );
            dishes_.Add("Основные блюда",
                new List<Dish>() {
                    new Dish("Плов", "Узбекский плов", 350, "Рис, мясо, морковь, специи", "C:\\reposit\\LR3\\mainDishes\\plov.jpg"),
                    new Dish("Котлеты с пюре", "Котлеты с картофельным пюре", 300, "Фарш, картофель, лук, молоко", "C:\\reposit\\LR3\\mainDishes\\cutlets.jpg"),
                    new Dish("Стейк", "Стейк из говядины", 450, "Говядина, соль, перец, травы", "C:\\reposit\\LR3\\mainDishes\\steak.jpg")
                }
            );
            dishes_.Add("Десерты",
                new List<Dish>() {
                    new Dish("Торт Наполеон", "Слоеный торт с кремом", 480, "Тесто, крем, сахарная пудра", "C:\\reposit\\LR3\\desserts\\napoleon.jpg"),
                    new Dish("Мороженое", "Ванильное мороженое", 120, "Молоко, сахар, ваниль", "C:\\reposit\\LR3\\desserts\\icecream.jpg"),
                    new Dish("Чизкейк", "Классический чизкейк", 220, "Сыр, печенье, сливки", "C:\\reposit\\LR3\\desserts\\cheesecake.jpg")
                }
            );
            dishes_.Add("Напитки",
                new List<Dish>() {
                    new Dish("Кофе", "Свежемолотый кофе", 50, "Кофейные зерна, вода", "C:\\reposit\\LR3\\drinks\\coffee.jpg"),
                    new Dish("Чай", "Черный чай с лимоном", 20, "Чай, лимон, сахар", "C:\\reposit\\LR3\\drinks\\tea.jpg"),
                    new Dish("Сок", "Апельсиновый сок", 70, "Апельсины", "C:\\reposit\\LR3\\drinks\\juice.jpg")
                }
            );

            List<string> allCategories = dishes_.Keys.ToList();
            MenuListBox.DataSource = allCategories;*/
        }

        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = MenuListBox.SelectedItem.ToString();
            List<Dish> dishesInCategory = dishes_[selectedCategory];
            Group_dishesСomboBox.DataSource = dishesInCategory;
            Group_dishesСomboBox.DisplayMember = "Name";
        }

        private void DishesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dish selectedDish = Group_dishesСomboBox.SelectedItem as Dish;
            if (selectedDish != null)
            {
                labelPrice.Text = selectedDish.Price + " руб.";
                labelDescription.Text = selectedDish.Description;
                labelIngredients.Text = selectedDish.Ingredients;
                pictureDish.Load(selectedDish.ImagePath);


            }
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            Dish selectedDish = Group_dishesСomboBox.SelectedItem as Dish;
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
                Dish dish = null;
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
                Dish dish = null;
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