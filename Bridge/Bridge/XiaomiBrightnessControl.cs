using System;
namespace Bridge
{
    public class XiaomiBrightnessControl : AbstractBrightnessControl
    {
        public XiaomiBrightnessControl(LEDdisplay ledDisplay) : base(ledDisplay)
        {
        }

        public override void SwitchOn()
        {
            ledDisplay.SwitchOn();
        }
        public override void SwitchOff()
        {
            ledDisplay.SwitchOff();
        }
        public override void SetBrightness(int displayBrightness)
        {
            ledDisplay.SetBrightness(displayBrightness);
        }
    }
}
