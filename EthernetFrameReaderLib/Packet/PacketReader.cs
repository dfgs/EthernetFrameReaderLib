using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public class PacketReader : IPacketReader
	{
		public Packet Read(byte[] Data)
		{
			PacketHeader header;

			byte version, headerLength;
			TypeOfService typeOfService;
			byte dscp, ecn,ttl;
			ushort totalLength,identification,fragmentOffset,headerChecksum;
			bool dontFragment, moreFragments;
			Protocols protocol;
			IPAddress sourceAddress, destinationAddress;
			byte[] padding,payload;

			if (Data == null) throw new ArgumentNullException(nameof(Data));
			if (Data.Length<20) throw new ArgumentOutOfRangeException(nameof(Data));

			version = (byte)((Data[0] & 240) >> 4);
			headerLength = (byte)((Data[0] & 15) * 4);

			dscp = (byte)((Data[1] & 252)>>2 );
			ecn = (byte)((Data[1] & 3) );

			typeOfService = new TypeOfService(dscp, ecn);

			totalLength = (ushort)((Data[2] << 8) + Data[3]);
			identification = (ushort)((Data[4] << 8) + Data[5]);

			dontFragment = (Data[6] & 64) != 0;
			moreFragments = (Data[6] & 32) != 0;

			fragmentOffset = (ushort)(Data[7] & 31);

			ttl = Data[8];

			try
			{
				protocol = (Protocols)Data[9];
			}
			catch (Exception)
			{
				throw new ArgumentOutOfRangeException("Invalid protocol");

			}

			headerChecksum= (ushort)((Data[10] << 8) + Data[11]);

			sourceAddress = new IPAddress(Data[12], Data[13], Data[14], Data[15]);
			destinationAddress = new IPAddress(Data[16], Data[17], Data[18], Data[19]);

			padding = Data.Skip(20).Take(headerLength-20).ToArray();

			header= new PacketHeader(version,headerLength,typeOfService, totalLength,identification,dontFragment,moreFragments, fragmentOffset,ttl,protocol,headerChecksum,sourceAddress,destinationAddress,padding);

			payload = Data.Skip(headerLength).Take(Data.Length - headerLength).ToArray();

			return new Packet(header,payload);


		}




	}
}
