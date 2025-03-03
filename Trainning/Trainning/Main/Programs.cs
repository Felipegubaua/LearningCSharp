using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainning.Programs_Developed;

namespace Trainning
{
    class Programs
    {
        // 1. First Felipe's code to test some tools.
        public static void Learning1() {
            Console.WriteLine("Please, write your complete name:");
            string name = Console.ReadLine();

            Console.WriteLine("How many rooms do you have in your house?");
            int rooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entry a product price: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Write your last name, age and height in one line: ");
            string[] s = Console.ReadLine().Split(' ');

            Console.WriteLine($"Your name is {name}, you have {rooms} rooms in your house, the product price is: {price:F2}.\n" +
                $"Last name: {s[0]}, age: {s[1]}, height: {double.Parse(s[2]):F2}.");
        }

        // 2. Calculating two triangles area.
        public static void Triangle() {
            Console.WriteLine("Entry with the X triangle measures: ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double z1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entry with the Y triangle measures: ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());

            Triangle t1 = new Triangle(x1, y1, z1);
            Triangle t2 = new Triangle(x2, y2, z2);
            Console.WriteLine($"Area de X: {t1.area()}");
            Console.WriteLine($"Area de Y: {t2.area()}");
        }

        // 3. A program about products price, increase and decrease number of products.
        public static void Products() {
            Console.WriteLine("Please, entry with products data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int qty = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, qty);
            Console.WriteLine($"Initial data: {product.ToString()}"); 

            Console.Write("Type the number of products to add in stock: ");
            product.addProducts(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Updated data: {product.ToString()}");
            
            Console.Write("Type the number of products to remove of the stock: ");
            product.removeProducts(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Updated data: {product.ToString()}");
        }
    }
}
