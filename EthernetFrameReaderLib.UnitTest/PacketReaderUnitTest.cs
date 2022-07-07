using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class PacketReaderUnitTest
	{
		[TestMethod]
		public void ShouldCheckIfDataIsNull()
		{
			PacketReader reader;

			reader= new PacketReader();
			Assert.ThrowsException<ArgumentNullException>(() => reader.Read(null));
		}
		[TestMethod]
		public void ShouldCheckIfDataIsTooSmall()
		{
			PacketReader reader;

			reader = new PacketReader();
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => reader.Read(Consts.PacketTooSmall));
		}//*/

		[TestMethod]
		public void ShouldReadPacket1()
		{
			PacketReader reader;
			Packet packet;

			reader = new PacketReader();

			packet = reader.Read(Consts.Packet1);
			Assert.AreEqual(4, packet.Header.Version);
			Assert.AreEqual(20, packet.Header.HeaderLength);
			Assert.AreEqual(0, packet.Header.TypeOfService.DSCP);
			Assert.AreEqual(40, packet.Header.TotalLength);
			Assert.AreEqual(4516, packet.Header.Identification);
			Assert.AreEqual(true, packet.Header.DontFragment);
			Assert.AreEqual(false, packet.Header.MoreFragments);
			Assert.AreEqual(0, packet.Header.FragmentOffset);
			Assert.AreEqual(128, packet.Header.TTL);
			Assert.AreEqual(Protocols.TCP, packet.Header.Protocol);
			Assert.AreEqual(0, packet.Header.HeaderChecksum);
			Assert.AreEqual("100.90.25.13", packet.Header.SourceAddress.ToString());
			Assert.AreEqual("10.17.0.95", packet.Header.DestinationAddress.ToString());
			Assert.IsNotNull(packet.Header.Padding);
			Assert.AreEqual(20, packet.Payload.Length);
			Assert.AreEqual(0x0d, packet.Payload[0]);

		}


		[TestMethod]
		public void ShouldReadPacket2()
		{
			PacketReader reader;
			Packet packet;

			reader = new PacketReader();

			packet = reader.Read(Consts.Packet2);
			Assert.AreEqual(4, packet.Header.Version);
			Assert.AreEqual(20, packet.Header.HeaderLength);
			Assert.AreEqual(10, packet.Header.TypeOfService.DSCP);
			Assert.AreEqual(0, packet.Header.TypeOfService.ECN);
			Assert.AreEqual(85, packet.Header.TotalLength);
			Assert.AreEqual(0, packet.Header.Identification);
			Assert.AreEqual(false, packet.Header.DontFragment);
			Assert.AreEqual(0, packet.Header.FragmentOffset);
			Assert.AreEqual(110, packet.Header.TTL);
			Assert.AreEqual(Protocols.UDP, packet.Header.Protocol);
			Assert.AreEqual(0x248f, packet.Header.HeaderChecksum);
			Assert.AreEqual("100.112.70.10", packet.Header.SourceAddress.ToString());
			Assert.AreEqual("100.90.25.13", packet.Header.DestinationAddress.ToString());
			Assert.IsNotNull(packet.Header.Padding);
			Assert.AreEqual(65, packet.Payload.Length);
			Assert.AreEqual(0x03, packet.Payload[0]);
		}


	}
}
