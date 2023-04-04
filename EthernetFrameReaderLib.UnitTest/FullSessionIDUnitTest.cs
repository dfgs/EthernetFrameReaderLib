using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class FullSessionIDUnitTest
	{
		[TestMethod]
		public void ShouldConvertToString()
		{
			FullSessionID fullSessionID;

			fullSessionID = new FullSessionID(new BoardID(1,2,3),12, new SessionID(0x00, 0x01, 0xe9, 0x1c, 0x47));
			Assert.AreEqual("010203:12:32054343", fullSessionID.ToString());
		}


	}
}
