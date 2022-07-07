using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public class UDPSegmentReader : IUDPSegmentReader
	{
		public UDPSegment Read(byte[] Data)
		{
			UDPHeader header;
			ushort sourcePort,destinationPort;
			byte[] payload;
			ushort length,checksum;

			if (Data == null) throw new ArgumentNullException(nameof(Data));
			if (Data.Length<8) throw new ArgumentOutOfRangeException(nameof(Data));

			sourcePort = (ushort)((Data[0] << 8) + Data[1]);
			destinationPort = (ushort)((Data[2] << 8) + Data[3]);
			length = (ushort)((Data[4] << 8) + Data[5]);
			checksum = (ushort)((Data[6] << 8) + Data[7]);

			header = new UDPHeader(sourcePort,destinationPort,length,checksum);

			payload = Data.Skip(8).Take(length-8).ToArray();


			return new UDPSegment(header,payload);


		}




	}
}
