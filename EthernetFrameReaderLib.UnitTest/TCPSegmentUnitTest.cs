using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class TCPSegmentUnitTest
	{
		[TestMethod]
		public void ShouldCheckIfPayloadIsNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() => new TCPSegment(new TCPHeader(), null));
		}


	}
}
