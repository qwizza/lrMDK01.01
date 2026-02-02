using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LR3
{
    public partial class MainForm : Form
    {
        private List<MenuGroup> menuGroups = new List<MenuGroup>();
        private Dictionary<string, List<Dish>> dishesByGroup = new Dictionary<string, List<Dish>>();
        private List<OrderItem> currentOrder = new List<OrderItem>();

        public MainForm()
        {
            InitializeComponent();
            InitializeMenuData();
            SetupEventHandlers();
        }
        private void InitializeMenuData()
        {
            menuGroups.Add(new MenuGroup("Супы", "Горячие первые блюда"));
            menuGroups.Add(new MenuGroup("Основные блюда", "Основные горячие блюда"));
            menuGroups.Add(new MenuGroup("Десерты", "Сладкие блюда"));
            menuGroups.Add(new MenuGroup("Напитки", "Холодные и горячие напитки"));

            MenuListBox.DataSource = menuGroups;
            MenuListBox.DisplayMember = "name_";

            InitializeDishes();
        }
        private void InitializeDishes()
        {
            var soups = new List<Dish>
            {
                new Dish("Борщ", "Красный борщ со сметаной", 250, "Свекла, капуста, мясо, сметана", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\soup\\borsch.jpg"),
                new Dish("Куриный суп", "Легкий куриный суп", 200, "Курина, лапша, морковь, лук", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\soup\\chicken_soup.jpg"),
                new Dish("Солянка", "Густой мясной суп", 280, "Разные виды мяса, огурцы, оливки", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\soup\\solyanka.jpg")
            };
            dishesByGroup["Супы"] = soups;

            var mainDishes = new List<Dish>
            {
                new Dish("Плов", "Узбекский плов", 350, "Рис, мясо, морковь, специи", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\mainDishes\\plov.jpg"),
                new Dish("Котлеты с пюре", "Котлеты с картофельным пюре", 300, "Фарш, картофель, лук, молоко", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\mainDishes\\cutlets.jpg"),
                new Dish("Стейк", "Стейк из говядины", 450, "Говядина, соль, перец, травы", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\mainDishes\\steak.jpg")
            };
            dishesByGroup["Основные блюда"] = mainDishes;

            var desserts = new List<Dish>
            {
                new Dish("Торт Наполеон", "Слоеный торт с кремом", 180, "Тесто, крем, сахарная пудра", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\desserts\\napoleon.jpg"),
                new Dish("Мороженое", "Ванильное мороженое", 120, "Молоко, сахар, ваниль", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\desserts\\icecream.jpg"),
                new Dish("Чизкейк", "Классический чизкейк", 220, "Сыр, печенье, сливки", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\desserts\\cheesecake.jpg")    
            };
            dishesByGroup["Десерты"] = desserts;

            var drinks = new List<Dish>
            {
                new Dish("Кофе", "Свежемолотый кофе", 150, "Кофейные зерна, вода", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\drinks\\coffee.jpg"),
                new Dish("Чай", "Черный чай с лимоном", 100, "Чай, лимон, сахар", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\drinks\\tea.jpg"),
                new Dish("Сок", "Апельсиновый сок", 120, "Апельсины", "C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\LR3\\drinks\\juice.jpg")
            };
            dishesByGroup["Напитки"] = drinks;

            UpdateDishesComboBox();
        }
        private void SetupEventHandlers()
        {
            Group_dishesСomboBox.SelectedIndexChanged += (s, e) =>
            {
                if (Group_dishesСomboBox.SelectedItem is Dish selectedDish)
                {
                    ShowDishInfo(selectedDish);
                }
            };
            MenuListBox.SelectedIndexChanged += (s, e) =>
            {
                UpdateDishesComboBox();
                ClearDishInfo();
            };
            btnAddToOrder.Click += (s, e) =>
            {
                AddToOrder();
            };

            btnPlaceOrder.Click += (s, e) =>
            {
                PlaceOrder();
            };

            btnClearOrder.Click += (s, e) =>
            {
                ClearOrder();
            };
            
        }
        private void UpdateDishesComboBox() 
        {
            if (MenuListBox.SelectedItem is MenuGroup selectedGroup) 
            {
                if (dishesByGroup.ContainsKey(selectedGroup.Name))
                {
                    Group_dishesСomboBox.DataSource = null;
                    Group_dishesСomboBox.DataSource = dishesByGroup[selectedGroup.Name];
                    Group_dishesСomboBox.DisplayMember = "nameDish_";
                }
            }
        }
        private void ShowDishInfo(Dish dish)
        {
            labelDishName.Text = dish.nameDish_;
            labelDescription.Text = $"Описание: {dish.descriptionDish_}";
            labelPrice.Text = $"Цена: {dish.priceDish_} руб.";
            labelIngredients.Text = $"Ингредиенты: {dish.ingredients_}";
            LoadDishImage(dish.imagePath_);
        }
        private void LoadDishImage(string imagePath)
        {
            try
            {
                if (System.IO.File.Exists(imagePath))
                {
                    // ВОТ ТАК ИСПОЛЬЗУЕТСЯ LOAD()!
                    pictureDish.Load(imagePath);
                }
                else
                {
                    // Если файл не найден
                    pictureDish.Image = null;
                    pictureDish.BackColor = Color.LightGray;
                    pictureDish.CreateGraphics().DrawString("Нет изображения",
                        new Font("Arial", 10), Brushes.Black, new PointF(10, 50));
                }
            }
            catch (Exception ex)
            {
                // Если ошибка загрузки
                pictureDish.Image = null;
                pictureDish.BackColor = Color.LightGray;
                labelIngredients.Text += $"\n(Ошибка: {ex.Message})";
            }
        }
        private void ClearDishInfo()
        {
            labelDishName.Text = "Название блюда";
            labelDescription.Text = "Описание блюда";
            labelPrice.Text = "Цена:";
            labelIngredients.Text = "Ингредиенты:";
            pictureDish.Image = null;
            pictureDish.BackColor = SystemColors.Control;
        }
        private void AddToOrder()
        {
            if (Group_dishesСomboBox.SelectedItem is Dish selectedDish)
            {
                int quantity = (int)numericUpDownQuantity.Value;

                currentOrder.Add(new OrderItem(selectedDish, quantity));

                UpdateOrderInfo();

                labelOrderStatus.Text = $"Добавлено: {selectedDish.nameDish_} x{quantity}";
                labelOrderStatus.ForeColor = Color.Green;

                UpdateOrderTextBox();
            }
            else
            {
                MessageBox.Show("Выберите блюдо из списка!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
              private void UpdateOrderInfo()
        {
            if (currentOrder.Count == 0)
            {
                labelOrderStatus.Text = "Заказ пуст";
                labelOrderStatus.ForeColor = Color.Black;
                return;
            }

            int totalItems = 0;
            foreach (var item in currentOrder)
            {
                totalItems += item.Quantity_;
            }

            labelOrderStatus.Text = $"В заказе: {currentOrder.Count} позиций ({totalItems} шт.)";
            labelOrderStatus.ForeColor = Color.Blue;
        }
        private void UpdateOrderTextBox()
        {
            textBoxOrder.Clear();

            var orderByGroup = new Dictionary<string, List<OrderItem>>();

            foreach (var orderItem in currentOrder)
            {
                string groupName = "";
                foreach (var group in dishesByGroup)
                {
                    if (group.Value.Contains(orderItem.Dish_))
                    {
                        groupName = group.Key;
                        break;
                    }
                }

                if (!orderByGroup.ContainsKey(groupName))
                    orderByGroup[groupName] = new List<OrderItem>();

                orderByGroup[groupName].Add(orderItem);
            }

            foreach (var group in orderByGroup)
            {
                textBoxOrder.AppendText($"{group.Key}:" + Environment.NewLine);

                foreach (var item in group.Value)
                {
                    textBoxOrder.AppendText($"  - {item.Dish_.nameDish_} x{item.Quantity_}" + Environment.NewLine);
                }

                textBoxOrder.AppendText(Environment.NewLine);
            }
        }
        private void PlaceOrder()
        {
            if (currentOrder.Count == 0)
            {
                MessageBox.Show("Заказ пуст! Добавьте блюда.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var summary = new Dictionary<string, int>();

            foreach (var orderItem in currentOrder)
            {

                foreach (var group in dishesByGroup)
                {
                    if (group.Value.Contains(orderItem.Dish_))
                    {
                        if (!summary.ContainsKey(group.Key))
                            summary[group.Key] = 0;

                        summary[group.Key] += orderItem.Quantity_;
                        break;
                    }
                }
            }

            string result = "Ваш заказ";
            decimal totalPrice = 0;

            foreach (var group in summary)
            {
                result += $"{group.Key}: {group.Value} позиций";
            }

            foreach (var item in currentOrder)
            {
                totalPrice += item.Dish_.priceDish_ * item.Quantity_;
            }

            result += $"Общая стоимость: {totalPrice} руб.";
            result += $"Спасибо за заказ!";

            MessageBox.Show(result, "Заказ оформлен",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearOrder();
        }
        private void ClearOrder()
        {
            currentOrder.Clear();
            textBoxOrder.Clear();
            UpdateOrderInfo();
            numericUpDownQuantity.Value = 1;
        }
    }
 
}