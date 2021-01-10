using System;
using System.Collections.Generic;
using System.Text;

namespace UASpemrog2765.Model
{
    class KeranjangBelanja
    {
        List<Item> itemkeranjangBelanja;
        Payment payment;
        onKeranjangBelanjaChangedListener onKeranjangBelanjaChangedListener;

        public KeranjangBelanja(Payment payment,onKeranjangBelanjaChangedListener onKeranjangBelanjaChangedListener)
        {
            this.payment = payment;
            this.onKeranjangBelanjaChangedListener = onKeranjangBelanjaChangedListener;
            this.itemkeranjangBelanja = new List<Item>();



        }
        public List<Item> getItems()
        {
            return this.itemkeranjangBelanja;
        }

       

        public void addItem(Item item)
        {
            this.itemkeranjangBelanja.Add(item);
            this.onKeranjangBelanjaChangedListener.addItemSucceed();
            calculateSubTotal();
        }

        public void removeItem(Item item)
        {
            this.itemkeranjangBelanja.Remove(item);
            this.onKeranjangBelanjaChangedListener.removeItemSucceed();
            calculateSubTotal();
        }

        private void calculateSubTotal()
        {
            double subTotal = 0;
            
            foreach (Item item in itemkeranjangBelanja)
            {
                subTotal += item.price;
                
            }
            payment.updateTotal(subTotal);
        }


    }

   

    interface onKeranjangBelanjaChangedListener
    {
        void removeItemSucceed();
        void addItemSucceed();

        
    }
}
