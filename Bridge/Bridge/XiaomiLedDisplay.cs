using System;
namespace Bridge
{
    public class XiaomiLedDisplay : LEDdisplay
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Xiaomi Display");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Xiaomi Display");
        }
        public void SetBrightness(int displayBrightness)
        {
            Console.WriteLine("Setting display brightness " + displayBrightness + " on Xiaomi Display");
        }
    }
}
