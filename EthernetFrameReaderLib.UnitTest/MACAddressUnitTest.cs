using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class MACAddressUnitTest
	{
		[TestMethod]
		public void ShouldConvertToString()
		{
			MACAddress macAddress;

			macAddress = new MACAddress(1, 2, 3, 4, 5, 6);
			Assert.AreEqual("01:02:03:04:05:06", macAddress.ToString());
			macAddress = new MACAddress(10, 11, 12, 13, 14, 15);
			Assert.AreEqual("0A:0B:0C:0D:0E:0F", macAddress.ToString());
			macAddress = new MACAddress(255, 255, 255, 255, 255, 255);
			Assert.AreEqual("FF:FF:FF:FF:FF:FF", macAddress.ToString());
		}


	}
}
