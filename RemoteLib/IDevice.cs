using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteLib
{
    public interface IDevice
    {
        bool IsOn();
        void TurnOff();
        void TurnOn();

        void VolumeUp(int VolumeIncrement);


    }
}
