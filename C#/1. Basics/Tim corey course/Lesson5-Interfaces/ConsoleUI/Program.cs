using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    partial class Program
    {
        static void Main(string[] args)
        {

            List<IComputerController> controllers = new List<IComputerController>();


            Keyboard keyboard = new Keyboard();
            GameContorler gameContorler = new GameContorler();
            BatteryPoweredGameController batteryController = new BatteryPoweredGameController();
            BatteryPoweredKeyboard  batteryKeyboard = new BatteryPoweredKeyboard();
            controllers.Add(keyboard);
            controllers.Add(gameContorler);
            
            

            foreach (var controller in controllers)
            {
                if (controller is GameContorler gc)
                {
                    gc.
                }

                if (controller is Keyboard k)
                {
                    k.
                }
                
            }
            List<IBatteryPowered> naBaterie= new List<IBatteryPowered>();
            naBaterie.Add(batteryController);
            naBaterie.Add(batteryKeyboard);


            Console.ReadLine();
            
        }
    }



}
