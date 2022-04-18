using System;
namespace Bridge
{
    public abstract class AbstractBrightnessControl
    {
        protected LEDdisplay ledDisplay;
        protected AbstractBrightnessControl(LEDdisplay ledDisplay)
        {
            this.ledDisplay = ledDisplay;
        }
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetBrightness(int displayBrightness);
    }
}
