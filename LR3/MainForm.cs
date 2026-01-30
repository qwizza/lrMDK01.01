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
                new Dish("Борщ", "Красный борщ со сметаной", 250, "Свекла, капуста, мясо, сметана"),
                new Dish("Куриный суп", "Легкий куриный суп", 200, "Курина, лапша, морковь, лук"),
                new Dish("Солянка", "Густой мясной суп", 280, "Разные виды мяса, огурцы, оливки")
            };
            dishesByGroup["Супы"] = soups;

            var mainDishes = new List<Dish>
            {
                new Dish("Плов", "Узбекский плов", 350, "Рис, мясо, морковь, специи"),
                new Dish("Котлеты с пюре", "Котлеты с картофельным пюре", 300, "Фарш, картофель, лук, молоко"),
                new Dish("Стейк", "Стейк из говядины", 450, "Говядина, соль, перец, травы")
            };
            dishesByGroup["Основные блюда"] = mainDishes;

            var desserts = new List<Dish>
            {
                new Dish("Торт Наполеон", "Слоеный торт с кремом", 180, "Тесто, крем, сахарная пудра"),
                new Dish("Мороженое", "Ванильное мороженое", 120, "Молоко, сахар, ваниль"),
                new Dish("Чизкейк", "Классический чизкейк", 220, "Сыр, печенье, сливки")
            };
            dishesByGroup["Десерты"] = desserts;

            var drinks = new List<Dish>
            {
                new Dish("Кофе", "Свежемолотый кофе", 150, "Кофейные зерна, вода"),
                new Dish("Чай", "Черный чай с лимоном", 100, "Чай, лимон, сахар"),
                new Dish("Сок", "Апельсиновый сок", 120, "Апельсины")
            };
            dishesByGroup["Напитки"] = drinks;

            UpdateDishesComboBox();
        }
        private void SetupEventHandlers()
        {
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
                if (dishesByGroup.ContainsKey(selectedGroup.name_))
                {
                    Group_dishesСomboBox.DataSource = null;
                    Group_dishesСomboBox.DataSource = dishesByGroup[selectedGroup.name_];
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
        }
        private void ClearDishInfo()
        {
            labelDishName.Text = "Название блюда";
            labelDescription.Text = "Описание блюда";
            labelPrice.Text = "Цена:";
            labelIngredients.Text = "Ингредиенты:";
            pictureDish.Image = null;
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
    }
 
}