namespace ConsoleUI
{
    partial class Program
    {
        public class BatteryPoweredKeyboard :Keyboard, IBatteryPowered
        {
            public int BatteryLevel { get; set; }
        }
    }
}