using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class FrameUnitTest
	{
		[TestMethod]
		public void ShouldCheckIfPayloadIsNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() => new Frame(new FrameHeader(),0, null));
		}


	}
}
