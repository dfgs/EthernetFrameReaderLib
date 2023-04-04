using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class BoardIDUnitTest
	{
		[TestMethod]
		public void ShouldConvertToString()
		{
			BoardID boardID;

			boardID = new BoardID(1, 2, 3);
			Assert.AreEqual("010203", boardID.ToString());
			boardID = new BoardID(10, 11, 15);
			Assert.AreEqual("0A0B0F", boardID.ToString());
			boardID = new BoardID(255, 255, 255);
			Assert.AreEqual("FFFFFF", boardID.ToString());
		}


	}
}
