using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class SessionIDUnitTest
	{
		[TestMethod]
		public void ShouldConvertToString()
		{
			SessionID SessionID;

			SessionID = new SessionID(0x00, 0x01, 0xe9, 0x1c, 0x47);
			Assert.AreEqual("32054343", SessionID.ToString());
		}


	}
}
