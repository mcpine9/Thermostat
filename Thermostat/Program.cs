using System.Threading;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoPlus;

namespace Thermostat
{
    public class Program
    {
        public static void Main()
        {
            // write your code here
            var ledPort = new OutputPort(Pins.ONBOARD_LED, false);

            while (true)
            {
                ledPort.Write(true);
                Thread.Sleep(1000);

                ledPort.Write(false);
                Thread.Sleep(1000);
            }


        }

    }
}
