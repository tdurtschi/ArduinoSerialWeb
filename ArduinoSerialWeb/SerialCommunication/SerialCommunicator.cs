using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Web;

namespace ArduinoSerialWeb.SerialCommunication
{
	public class SerialCommunicator
	{
		SerialPort serialPort;

		public SerialCommunicator()
		{
			try{
				var portNames = SerialPort.GetPortNames();

				serialPort = new SerialPort();

				serialPort.PortName = portNames != null ? portNames[0] : "COM4";
				serialPort.BaudRate = 9600;
				serialPort.ReadTimeout = 500;
				serialPort.WriteTimeout = 500;
				serialPort.Open();

				Console.WriteLine( "Now Connected to {0}", serialPort.PortName );
			}
			catch (Exception ex)
			{
				//Arduino is likely unplugged. Stay alive for testing purposes.
				Console.WriteLine( "Error connecting to Arduino. Details:\n" + ex.Message );
				serialPort = null;
			}
		}

		public void Write( string message )
		{
			if( serialPort != null )
			{
				serialPort.Write( message );
			}
		}
	}
}