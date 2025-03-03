using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Trainning.Programs_Developed
{
    class Product
    {
        private string name;
        private double price;
        private int qty;

        // Constructor 1, receiving a initial qty 
        public Product(string name, double price, int qty) {
            this.name = name;
            this.price = price;
            this.qty = qty;
        }

        // Constructor 2 (overload), not receiving a initial qty (it will be 0)
        public Product(string name, double price) {
            this.name = name;
            this.price = price;
            this.qty = 0;           // Just to make it visible. By pattern, it already is initialized as 0
        }

        public double TotalStockValue() {
            return price * qty;
        }

        public void addProducts(int qty) {
            this.qty += qty;
        }

        public void removeProducts(int qty) {
            if((this.qty - qty) < 0) {
                Console.WriteLine($"The number of products cannot be less than 0, current is: {this.qty}. Operation was not realized.");
            }
            else { 
                this.qty -= qty; 
            }   
        }

        public override string ToString() {
            return $"For the {name}, we have {qty} units in stock, and each one is costing {price:F2}. Total value in stock for that product is {(price*qty):F2}.";
        }
    }
}
