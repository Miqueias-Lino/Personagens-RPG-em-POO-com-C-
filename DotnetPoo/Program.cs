using DotnetPoo.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotnetPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, 100, "Knigth");
            Wizard wizard = new Wizard("Jennica", 23, 100, "White Wizard");
            Ninja wedge = new Ninja("wedge", 23, 100, "Ninja");
            BlackWizard blackWizard = new BlackWizard("Topapa", 50, 100, "Black Wizard");

            Console.WriteLine(wedge.Attack(5));
            Console.WriteLine(arus.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(blackWizard.Attack(8));

            Console.ReadLine();
        }
    }
}
