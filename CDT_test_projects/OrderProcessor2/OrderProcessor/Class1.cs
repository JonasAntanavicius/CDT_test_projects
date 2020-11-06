using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace OrderProcessor
{
    public class Order
    {
        private Product productOrdered;

        public Product ProductOrdered
        {
            get
            {
                return this.productOrdered;
            }
            set
            {
                this.productOrdered = value;
            }
        }

        private int quantity;

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }
    }
}
