using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProcessor
{
    public class Product
    {

        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        private string vatClass;

        public string VatClass
        {
            get
            {
                return this.vatClass;
            }
            set
            {
                this.vatClass = value;
            }
        }

        private decimal unitPrice;

        public decimal UnitPrice
        {
            get
            {
                return this.unitPrice;
            }
            set
            {
                this.unitPrice = value;
            }
        }
    }
}
