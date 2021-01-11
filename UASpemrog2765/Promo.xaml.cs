using System;
using System.Collections.Generic;
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
    /// Interaction logic for Promo.xaml
    /// </summary>
    public partial class Promo : Window
    {
        PromoController promoController;
        OnPromoChangedListener promoListener;
        public Promo()
        {
            InitializeComponent();
            promoController = new PromoController();
            listBoxDaftarPromo.ItemsSource = promoController.getPromo();

            generateContentPromo();
        }

        public void SetOnPromoSelectedListener(OnPromoChangedListener promoListener)
        {
            this.promoListener = promoListener;
        }

        private void generateContentPromo()
        {
            Model.Promo promo1 = new Model.Promo("Promo Awal tahun Diskon 25 % ", 1);
            Model.Promo promo2 = new Model.Promo("Promo Tebus Murah Diskon 30 % atau maksimal 30.000", 2);
            Model.Promo promo3 = new Model.Promo("Promo Natal Potongan 10000", 3);

            promoController.addPromo(promo1);
            promoController.addPromo(promo2);
            promoController.addPromo(promo3);

            listBoxDaftarPromo.Items.Refresh();
        }

        private void onlistBoxDaftarPromoClicked(object sender, MouseButtonEventArgs e)
        {
            ListBox listbox = sender as ListBox;
            Model.Promo promo = listbox.SelectedItem as Model.Promo;
            this.promoListener.OnPromoSelected(promo);
            this.Close();
        }
    }

    public interface OnPromoChangedListener
    {
        void OnPromoSelected(Model.Promo promos);
    }
}
