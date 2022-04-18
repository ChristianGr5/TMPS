using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            XiaomiBrightnessControl xiaomiBrightnessControl = new XiaomiBrightnessControl(new XiaomiLedDisplay());
            xiaomiBrightnessControl.SwitchOn();
            xiaomiBrightnessControl.SetBrightness(99);
            xiaomiBrightnessControl.SwitchOff();

            Console.WriteLine();
            AppleBrightnessControl appleBrightnessControl = new AppleBrightnessControl(new AppleLedDisplay());
            appleBrightnessControl.SwitchOn();
            appleBrightnessControl.SetBrightness(50);
            appleBrightnessControl.SwitchOff();

            Console.ReadKey();
        }
    }
}
