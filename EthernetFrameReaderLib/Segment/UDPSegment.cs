using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct UDPSegment: ISegment
	{
		ISegmentHeader ISegment.Header => Header;
		public UDPHeader Header
		{
			get;
			private set;
		}

		public byte[] Payload
		{
			get;
			private set;
		}


		public UDPSegment(UDPHeader Header, byte[] Payload)
		{
			if (Payload == null) throw new ArgumentNullException(nameof(Payload));
			this.Header = Header;this.Payload = Payload;

		}


	}
}
