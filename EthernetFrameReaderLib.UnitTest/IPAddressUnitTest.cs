using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class IPAddressUnitTest
	{
		[TestMethod]
		public void ShouldConvertToString()
		{
			IPAddress ipAddress;

			ipAddress = new IPAddress(1, 2, 3, 4);
			Assert.AreEqual("1.2.3.4", ipAddress.ToString());
			ipAddress = new IPAddress(10, 11, 12, 13);
			Assert.AreEqual("10.11.12.13", ipAddress.ToString());
			ipAddress = new IPAddress(255, 255, 255, 255);
			Assert.AreEqual("255.255.255.255", ipAddress.ToString());
		}


	}
}
