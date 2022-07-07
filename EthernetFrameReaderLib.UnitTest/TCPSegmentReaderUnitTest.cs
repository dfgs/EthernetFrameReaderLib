using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class TCPSegmentReaderUnitTest
	{
		[TestMethod]
		public void ShouldCheckIfDataIsNull()
		{
			TCPSegmentReader reader;

			reader= new TCPSegmentReader();
			Assert.ThrowsException<ArgumentNullException>(() => reader.Read(null));
		}
		[TestMethod]
		public void ShouldCheckIfDataIsTooSmall()
		{
			TCPSegmentReader reader;

			reader = new TCPSegmentReader();
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => reader.Read(Consts.TCPSegmentTooSmall));
		}//*/

		[TestMethod]
		public void ShouldReadTCPSegment1()
		{
			TCPSegmentReader reader;
			TCPSegment TCPSegment;

			reader = new TCPSegmentReader();

			TCPSegment = reader.Read(Consts.TCPSegment1);
			Assert.AreEqual(3389, TCPSegment.Header.SourcePort);
			Assert.AreEqual(63657, TCPSegment.Header.DestinationPort);
			Assert.AreEqual(3325961964, TCPSegment.Header.SequenceNumber);
			Assert.AreEqual(3954225213, TCPSegment.Header.AcknowledgmentNumber);
			Assert.AreEqual(20, TCPSegment.Header.HeaderLength);
			Assert.AreEqual(false, TCPSegment.Header.Flag.ECN);
			Assert.AreEqual(false, TCPSegment.Header.Flag.CWR);
			Assert.AreEqual(false, TCPSegment.Header.Flag.ECE);
			Assert.AreEqual(false, TCPSegment.Header.Flag.URG);
			Assert.AreEqual(true, TCPSegment.Header.Flag.ACK);
			Assert.AreEqual(false, TCPSegment.Header.Flag.PSH);
			Assert.AreEqual(false, TCPSegment.Header.Flag.RST);
			Assert.AreEqual(false, TCPSegment.Header.Flag.SYN);
			Assert.AreEqual(false, TCPSegment.Header.Flag.FIN);
			Assert.AreEqual(63353, TCPSegment.Header.Window);
			Assert.AreEqual(0x87f1, TCPSegment.Header.Checksum);
			Assert.AreEqual(0, TCPSegment.Header.UrgentPointer);

			Assert.AreEqual(0, TCPSegment.Payload.Length);
			//Assert.AreEqual(0x0d, TCPSegment.Payload[0]);

		}
		[TestMethod]
		public void ShouldReadTCPSegment2()
		{
			TCPSegmentReader reader;
			TCPSegment TCPSegment;

			reader = new TCPSegmentReader();

			TCPSegment = reader.Read(Consts.TCPSegment2);
			Assert.AreEqual(63657, TCPSegment.Header.SourcePort);
			Assert.AreEqual(3389, TCPSegment.Header.DestinationPort);
			Assert.AreEqual(3954225213, TCPSegment.Header.SequenceNumber);
			Assert.AreEqual(3325961964, TCPSegment.Header.AcknowledgmentNumber);
			Assert.AreEqual(20, TCPSegment.Header.HeaderLength);
			Assert.AreEqual(false, TCPSegment.Header.Flag.ECN);
			Assert.AreEqual(false, TCPSegment.Header.Flag.CWR);
			Assert.AreEqual(false, TCPSegment.Header.Flag.ECE);
			Assert.AreEqual(false, TCPSegment.Header.Flag.URG);
			Assert.AreEqual(true, TCPSegment.Header.Flag.ACK);
			Assert.AreEqual(true, TCPSegment.Header.Flag.PSH);
			Assert.AreEqual(false, TCPSegment.Header.Flag.RST);
			Assert.AreEqual(false, TCPSegment.Header.Flag.SYN);
			Assert.AreEqual(false, TCPSegment.Header.Flag.FIN);
			Assert.AreEqual(513, TCPSegment.Header.Window);
			Assert.AreEqual(0x3252, TCPSegment.Header.Checksum);
			Assert.AreEqual(0, TCPSegment.Header.UrgentPointer);

			Assert.AreEqual(43, TCPSegment.Payload.Length);
			Assert.AreEqual(0x17, TCPSegment.Payload[0]);

		}



	}
}
