using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UASpemrog2765.Model
{
    class Payment
    {
        private double balance = 0;
        public List<Promo> promodigunakan;
        OnPaymentChangedListener paymentListener;
        public Payment(OnPaymentChangedListener paymentListener)
        {
            
            this.paymentListener = paymentListener;
            this.promodigunakan = new List<Promo>();

            

        }
        public List<Promo> getPromo()
        {
            return this.promodigunakan;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public double getBalance()
        {
            return this.balance;
        }
    
        

        public void addPromo(Promo promos)
        {
            this.promodigunakan.Clear();
            this.promodigunakan.Add(promos);
            this.paymentListener.addPromoSucceed();
        }

       

        public void updateTotal(double subTotal)
        {
            double promo = 0;

            foreach (Promo promos in promodigunakan)
            {
                if (promos.potongan == 1)
                {
                    promo = (subTotal * 25 / 100);
                }
                else if (promos.potongan == 2)
                {
                   
                    promo = (subTotal * 30 / 100);

                    if(promo > 30000)
                    {
                        promo = 30000;
                    }
                }
                else if (promos.potongan == 3)
                {
                    promo = 10000;
                    
                }
                
            }

            double total = subTotal - promo;
            this.paymentListener.onPriceUpdated(subTotal, total);
            
        }
    }

    interface OnPaymentChangedListener
    {
        void onPriceUpdated(double subtTotal, double total);

        void addPromoSucceed();
    }
}
