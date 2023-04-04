using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct Packet
	{
		public PacketHeader Header
		{
			get;
			private set;
		}

		public byte[] Payload
		{
			get;
			private set;
		}
		public Packet(PacketHeader Header, byte[] Payload)
		{
			if (Payload == null) throw new ArgumentNullException(nameof(Payload));
			this.Header = Header;this.Payload = Payload;

		}


	}
}
