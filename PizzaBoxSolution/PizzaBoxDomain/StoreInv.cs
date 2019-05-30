using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxDomain
{
    public class StoreInv
    {
        private string invid;
        private int invlocation;
        private int doughqty;
        private int cheeseqty;
        private int sauceqty;
        private int pepperoniqty;
        private int sausageqty;
        private int baconqty;
        private int pineappleqty;
        private int mushroomqty;
        private int onionqty;
        private int oliveqty;

        public int InvId { get; set; }
        public int InvLocation { get; set; }
        public int DoughQty { get; set; }
        public int CheeseQty { get; set; }
        public int SauceQty { get; set; }
        public int PepperoniQty { get; set; }
        public int SausageQty { get; set; }
        public int BaconQty { get; set; }
        public int PineappleQty { get; set; }
        public int MushroomQty { get; set; }
        public int OnionQty { get; set; }
        public int OliveQty { get; set; }
    }
}
