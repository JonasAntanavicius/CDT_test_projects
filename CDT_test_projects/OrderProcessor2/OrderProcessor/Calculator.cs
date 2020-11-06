using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProcessor
{
    public class Calculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>The total price for all items the customer has ordered, including VAT where applicable</returns>
        public decimal Calculate(List<Order> orders)
        {
            decimal t = 0m;

            foreach (var order in orders)
            {
                if (order.ProductOrdered.VatClass == "Standard")
                {
                    t = t + (order.ProductOrdered.UnitPrice * order.Quantity * 1.2m);
                }
                else
                {
                    if (order.ProductOrdered.VatClass == "Reduced")
                    {
                        t = t + (order.ProductOrdered.UnitPrice * order.Quantity * 1.05m);
                    }
                    else
                    {
                        if (order.ProductOrdered.VatClass == "Zero")
                        {
                            t = t + (order.ProductOrdered.UnitPrice * order.Quantity * 1m);
                        }
                        else
                        {
                            if (order.ProductOrdered.VatClass == "Exempt")
                            {
                                t = t + (order.ProductOrdered.UnitPrice * order.Quantity);
                            }
                            else
                            {
                                throw new ArgumentException("VatClass not recognised for product: " + order.ProductOrdered.Name);
                            }
                        }
                    }
                }
            }

            return t;
        }

    }
}
