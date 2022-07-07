using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct UDPHeader: ISegmentHeader
	{
		public ushort SourcePort
		{
			get;
			private set;
		}

		public ushort DestinationPort
		{
			get;
			private set;
		}
		public ushort Length
		{
			get;
			private set;
		}
		public ushort Checksum
		{
			get;
			private set;
		}


		public UDPHeader(ushort SourcePort,ushort DestinationPort, ushort Length, ushort Checksum)
		{
			
			this.SourcePort = SourcePort;this.DestinationPort = DestinationPort;
			this.Length = Length;this.Checksum = Checksum;
		}


	}
}
