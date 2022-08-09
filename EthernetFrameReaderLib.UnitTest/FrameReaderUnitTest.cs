using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class FrameReaderUnitTest
	{
		[TestMethod]
		public void ShouldCheckIfDataIsNull()
		{
			FrameReader reader;

			reader= new FrameReader();
			Assert.ThrowsException<ArgumentNullException>(() => reader.Read(null));
		}
		[TestMethod]
		public void ShouldCheckIfDataIsTooSmall()
		{
			FrameReader reader;

			reader = new FrameReader();
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => reader.Read(Consts.FrameTooSmall));
		}

		[TestMethod]
		public void ShouldReadFrame1()
		{
			FrameReader reader;
			Frame frame;

			reader = new FrameReader();
			frame = reader.Read(Consts.Frame1);
			Assert.AreEqual("00:50:56:82:A4:03", frame.Header.SourceAddress.ToString());
			Assert.AreEqual("00:1C:7F:3B:D4:4F", frame.Header.DestinationAddress.ToString());
			Assert.AreEqual(EtherTypes.IPv4, frame.Header.EtherType);
			Assert.AreEqual(40, frame.Payload.Length);
			Assert.AreEqual(0x45, frame.Payload[0]);
		}
		[TestMethod]
		public void ShouldReadFrame4()
		{
			FrameReader reader;
			Frame frame;

			reader = new FrameReader();
			frame = reader.Read(Consts.Frame4);
			Assert.AreEqual("00:00:00:00:00:00", frame.Header.SourceAddress.ToString());
			Assert.AreEqual("00:00:00:00:00:00", frame.Header.DestinationAddress.ToString());
			Assert.AreEqual(EtherTypes.VLANTagged, frame.Header.EtherType);
			Assert.AreEqual(2110, frame.VlanID);
			Assert.AreEqual(1133, frame.Payload.Length);
			Assert.AreEqual(0x45, frame.Payload[0]);
		}

	}
}
