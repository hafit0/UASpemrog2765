using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UASpemrog2765.Controller;
using UASpemrog2765.Model;

namespace UASpemrog2765
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        MenuController menuController;
        OnMenuChangedListener listener;
        public Menu()
        {
            
            InitializeComponent();
            menuController = new MenuController();
            listMenu.ItemsSource = menuController.getItems();

            generateContentMenu();
        }

        public void SetOnItemSelectedListener(OnMenuChangedListener listener)
        {
            this.listener = listener;
        }
        private void listMenuOnDoubleClicked(object sender, MouseButtonEventArgs e)
        {
            ListBox listbox = sender as ListBox;
            Item item = listbox.SelectedItem as Item;
            this.listener.OnMenuSelected(item);

            
        }

        private void generateContentMenu()
        {
            Item menu1 = new Item("Coffe Late", 30000);
            Item menu2 = new Item("Black Tea", 20000);
            Item menu3 = new Item("Pizza", 75000);
            Item menu4 = new Item("Milk Shake", 15000);
            Item menu5 = new Item("Fried Frice Special", 45000);
            Item menu6 = new Item("Watermelon Juice", 25000);
            Item menu7 = new Item("Lemon Squash", 30000);

            menuController.addItem(menu1);
            menuController.addItem(menu2);
            menuController.addItem(menu3);
            menuController.addItem(menu4);
            menuController.addItem(menu5);
            menuController.addItem(menu6);
            menuController.addItem(menu7);

            listMenu.Items.Refresh();

        }


        
    }
    public interface OnMenuChangedListener
    {
        void OnMenuSelected(Item item);
    }
}
