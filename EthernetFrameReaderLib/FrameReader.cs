using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public class FrameReader : IFrameReader
	{
		public Frame Read(byte[] Data)
		{
			MACAddress source, destination;
			FrameHeader header;
			EtherTypes etherType;
			byte[] payload;
			ushort vlanID;
			//uint CRC;

			if (Data == null) throw new ArgumentNullException(nameof(Data));
			if (Data.Length<18) throw new ArgumentOutOfRangeException(nameof(Data));

			destination = new MACAddress(Data[0], Data[1], Data[2], Data[3], Data[4], Data[5]);
			source = new MACAddress(Data[6], Data[7], Data[8], Data[9], Data[10], Data[11]);

			try
			{
				etherType = (EtherTypes)(Data[12] << 8 + Data[13]);
			}
			catch(Exception)
			{
				throw new ArgumentOutOfRangeException("Invalid ethertype");
			}

			header = new FrameHeader(source, destination, etherType);
			if (etherType==EtherTypes.VLANTagged)
			{
				vlanID = (ushort)((Data[14] << 8) + Data[15]);
				payload = Data.Skip(18).Take(Data.Length - 18).ToArray();
			}
			else
			{
				vlanID = 0;
				payload = Data.Skip(14).Take(Data.Length - 14).ToArray();
			}

			//CRC = (uint)(Data[Data.Length - 4]<<24) + (uint)(Data[Data.Length - 3] << 16) + (uint)(Data[Data.Length - 2] << 8) + (uint)(Data[Data.Length - 1]) ;

			return new Frame(header,vlanID,payload);
		}
	}
}
