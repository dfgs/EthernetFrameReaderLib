using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class UDPSegmentReaderUnitTest
	{
		[TestMethod]
		public void ShouldCheckIfDataIsNull()
		{
			UDPSegmentReader reader;

			reader= new UDPSegmentReader();
			Assert.ThrowsException<ArgumentNullException>(() => reader.Read(null));
		}
		[TestMethod]
		public void ShouldCheckIfDataIsTooSmall()
		{
			UDPSegmentReader reader;

			reader = new UDPSegmentReader();
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => reader.Read(Consts.UDPSegmentTooSmall));
		}//*/

		[TestMethod]
		public void ShouldReadUDPSegment1()
		{
			UDPSegmentReader reader;
			UDPSegment UDPSegment;

			reader = new UDPSegmentReader();

			UDPSegment = reader.Read(Consts.UDPSegment1);
			Assert.AreEqual(926, UDPSegment.Header.SourcePort);
			Assert.AreEqual(925, UDPSegment.Header.DestinationPort);
			Assert.AreEqual(65, UDPSegment.Header.Length);
			Assert.AreEqual(0, UDPSegment.Header.Checksum);

			Assert.AreEqual(57, UDPSegment.Payload.Length);
			Assert.AreEqual(0x09, UDPSegment.Payload[0]);

		}
		



	}
}
