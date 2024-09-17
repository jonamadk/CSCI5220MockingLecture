
namespace RemoteLib
{
    public class Remote
    {
        private IDevice _device;

        public Remote(IDevice device)
        {
            _device = device;
        }

        public void ToggleDevicePower()
        {
            _device.TurnOn();
        }
    }
}
