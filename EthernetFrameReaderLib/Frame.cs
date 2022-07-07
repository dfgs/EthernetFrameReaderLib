using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct Frame
	{
		public FrameHeader Header
		{
			get;
			private set;
		}
		
		public byte[] Payload
		{
			get;
			private set;
		}
		/*public uint CRC
		{
			get;
			private set;
		}*/

		public Frame(FrameHeader Header, byte[] Payload)
		{
			if (Payload == null) throw new ArgumentNullException(nameof(Payload));
			this.Header = Header;this.Payload = Payload;//this.CRC = CRC;
		}
	}
}
