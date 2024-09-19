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



        [Test]
        public void CanSendTurnOffMessageToDevice()
        {
            IDevice device = Substitute.For<IDevice>();
            Remote sut = new(device);
            device.IsOn().Returns(true);
            sut.ToggleDevicePower(); //Turn off

            //Assert that device  received the call
            device.Received().TurnOff();
            device.DidNotReceive().TurnOn();



        }

        [Test]
        public void CanTurnUpTheVolumeOfTheDevice()
        {

            IDevice device = Substitute.For<IDevice>();
            Remote sut = new(device);
            device.IsOn().Returns(true);
            sut.VolumeUp(1);
            device.Received().VolumeUp(1);




        }

    }
}