namespace ConsoleUI
{
    partial class Program
    {
        public interface IBatteryPowered
        {
            int BatteryLevel { get; set; }
        }
    }
}