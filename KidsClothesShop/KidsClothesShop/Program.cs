using KidsClothesShop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsClothesShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to use? 1.Form Application. / 2.Console Application.");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else if (choice == 2)
            {
                Display display = new Display();
            }
            else
            {
                Console.WriteLine("It must be 1 or 2!");
            }
        }
    }
}
