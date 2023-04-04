using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public class TCPSegmentReader : ITCPSegmentReader
	{
		public TCPSegment Read(byte[] Data)
		{
			TCPHeader header;
			ushort sourcePort,destinationPort;
			byte[] payload;
			uint sequenceNumber, acknowledgmentNumber;
			ushort headerLength,window, checksum,urgentPointer;
			TCPHeaderFlag flag;
			ushort headerSizeWithPadding;

			if (Data == null) throw new ArgumentNullException(nameof(Data));
			if (Data.Length<20) throw new ArgumentOutOfRangeException(nameof(Data));

			sourcePort = (ushort)((Data[0] << 8) + Data[1]);
			destinationPort = (ushort)((Data[2] << 8) + Data[3]);

			sequenceNumber = (uint)((Data[4] << 24) + (Data[5] << 16) + (Data[6] << 8) + Data[7]);
			acknowledgmentNumber = (uint)((Data[8] << 24) + (Data[9] << 16) + (Data[10] << 8) + Data[11]);
			headerLength= (ushort)(((Data[12] & 240) >> 4)*4);

			flag = new TCPHeaderFlag((Data[12] & 1) != 0, (Data[13] & 128) != 0, (Data[13] & 64) != 0, (Data[13] & 32) != 0, (Data[13] & 16) != 0, (Data[13] & 8) != 0, (Data[13] & 4) != 0, (Data[13] & 2) != 0, (Data[13] & 1) != 0 );

			window = (ushort)((Data[14] << 8) + Data[15]);
			checksum = (ushort)((Data[16] << 8) + Data[17]);
			urgentPointer = (ushort)((Data[18] << 8) + Data[19]);

			header = new TCPHeader(sourcePort,destinationPort,sequenceNumber,acknowledgmentNumber, headerLength,flag,window,checksum,urgentPointer);

			headerSizeWithPadding = (ushort)(Math.Ceiling(headerLength / 4.0f) * 4);
			payload = Data.Skip(headerSizeWithPadding).Take(Data.Length-headerSizeWithPadding).ToArray();


			return new TCPSegment(header,payload);


		}




	}
}
