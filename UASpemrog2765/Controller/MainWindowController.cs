using System;
using System.Collections.Generic;
using System.Text;
using UASpemrog2765.Model;

namespace UASpemrog2765.Controller
{
    
    class MainWindowController
    {
        KeranjangBelanja keranjangBelanja;
        Payment payment;


        public MainWindowController(KeranjangBelanja keranjangBelanja, Payment payment)
        {
            this.keranjangBelanja = keranjangBelanja;
            this.payment = payment;
        }

        public void addItem(Item item)
        {
            this.keranjangBelanja.addItem(item);
        }

        public void removeItem(Item item)
        {
            this.keranjangBelanja.removeItem(item);
        }

        public List<Item> getItems()
        {
            return this.keranjangBelanja.getItems();
        }

        public void addPromo(Model.Promo diskon)
        {
            
            this.payment.addPromo(diskon);
        }

        public List<Model.Promo> getPromo()
        {
            return this.payment.getPromo();
        }


    }
}
