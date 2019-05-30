using PizzaBoxData.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxData
{
    public sealed class DBInstance //Singleton
    {
        private static PizzaBoxContext instance = null;
        private DBInstance()
        {

        }

        public static PizzaBoxContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PizzaBoxContext();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        }
    }
}
