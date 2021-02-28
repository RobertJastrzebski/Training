namespace ConsoleUI
{
    partial class Program
    {
        public class BatteryPoweredGameController : GameContorler, IBatteryPowered
        {
            public int BatteryLevel { get; set; }

            
        }
    }
}