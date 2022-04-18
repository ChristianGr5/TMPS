using System;
namespace Bridge
{
    public class AppleLedDisplay : LEDdisplay
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Apple Display");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Apple Display");
        }
        public void SetBrightness(int displayBrightness)
        {
            Console.WriteLine("Setting display brightness " + displayBrightness + " on Apple Display");
        }
    }
}
