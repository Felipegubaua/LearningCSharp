using System;
using System.ComponentModel.Design;

namespace Trainning {
    class Menu {
        static void Main(String[] args) {
            Console.WriteLine("Hello, welcome to the Felipe's C# learning.");
            int option = 1;
            while ((option = WriteMenu()) != 0) {
                ExecuteAction(option);
            }
            Console.WriteLine("Thanks by visiting Felipe's C# learning, see you next time.");
        }

        static int WriteMenu() {
            Console.WriteLine("You can select what you wanna do in the menu bellow: \n");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("1. First Felipe's code to test some tools.");
            Console.WriteLine("2. Calculating two triangles area.");
            Console.WriteLine("3. A program about products price, increase and decrease number of products.");
            Console.WriteLine("0. Exit the program");
            Console.WriteLine("===================================================================================");

            Console.WriteLine("Please, type the number corresponding to what you want to do now: ");
            return int.Parse(Console.ReadLine());
        }

        static void ExecuteAction(int option) {
            Console.Clear();
            switch (option) {
                case 1:
                    Programs.Learning1();
                    break;
                case 2:
                    Programs.Triangle();
                    break;
                case 3:
                    Programs.Products();
                    break;
                default:
                    Console.WriteLine("Invalid option, there are no action matching to typed option. Try again.");
                    break;
            }
            Console.WriteLine("Press any button to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}