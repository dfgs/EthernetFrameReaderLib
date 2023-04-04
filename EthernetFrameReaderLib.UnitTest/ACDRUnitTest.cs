using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class ACDRUnitTest
	{
		[TestMethod]
		public void ShouldCheckIfPayloadIsNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() => new ACDR(new ACDRHeader(),new FullSessionID(new BoardID(),0,new SessionID()), null));
		}


	}
}
