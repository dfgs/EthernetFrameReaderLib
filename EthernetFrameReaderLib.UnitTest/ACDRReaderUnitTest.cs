using EthernetFrameReaderLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EthernetFrameReaderLib.UnitTest
{
	[TestClass]
	public class ACDRReaderUnitTest
	{
		[TestMethod]
		public void ShouldCheckIfDataIsNull()
		{
			ACDRReader reader;

			reader= new ACDRReader();
			Assert.ThrowsException<ArgumentNullException>(() => reader.Read(null));
		}
		[TestMethod]
		public void ShouldCheckIfDataIsTooSmall()
		{
			ACDRReader reader;

			reader = new ACDRReader();
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => reader.Read(Consts.ACDRTooSmall));
		}//*/

		[TestMethod]
		public void ShouldReadACDR1()
		{
			ACDRReader reader;
			ACDR ACDR;

			reader = new ACDRReader();

			ACDR = reader.Read(Consts.ACDR1);
			Assert.AreEqual(9, ACDR.Header.Version);
			Assert.AreEqual(2397586379, ACDR.Header.TimeStamp);
			Assert.AreEqual(36323, ACDR.Header.SequenceNumber);
			Assert.AreEqual(8269u, ACDR.Header.SourceID);
			Assert.AreEqual(8269u, ACDR.Header.DestID);
			Assert.AreEqual(00, ACDR.Header.ExtraData);
			Assert.AreEqual(TracePoints.DspDecoder, ACDR.Header.TracePoint);
			Assert.AreEqual(MediaTypes.ACDR_RTP, ACDR.Header.MediaType);
			Assert.AreEqual(9, ACDR.Header.HeaderExtensionLength);


		}




	}
}
