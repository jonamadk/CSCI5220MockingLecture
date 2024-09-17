using RemoteLib;
using NSubstitute;

namespace RemoteLibTesting
{

    [Category("Remote Unit Testing")]
    public class ARemote
    {
       

        [Test]
        public void CanSendTurnOnMessageToDevice()
        {

            IDevice device = Substitute.For<IDevice>();
            Remote sut = new(device);
            sut.ToggleDevicePower();

            //Assert.Fail the device received the call
            device.Received().TurnOn();
            //Assert.Fail("Work in Progress");
        }
    }
}