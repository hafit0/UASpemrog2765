using System;
using System.Collections.Generic;
using System.Text;
using UASpemrog2765.Model;

namespace UASpemrog2765.Controller
{
    class PromoController
    {
        public List<Model.Promo> promos;

        public PromoController()
        {
            promos = new List<Model.Promo>();
        }

        public void addPromo(Model.Promo promos)
        {
            this.promos.Add(promos);
        }

        public List<Model.Promo> getPromo()
        {
            return this.promos;
        }
    }
}
