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
    }
}