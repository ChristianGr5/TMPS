using System;
namespace Bridge
{
    public interface LEDdisplay
    {
        void SwitchOn();
        void SwitchOff();
        void SetBrightness(int displayBrightness);
    }
}
