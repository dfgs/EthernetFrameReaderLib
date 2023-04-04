using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct ACDR
	{
		public ACDRHeader Header
		{
			get;
			private set;
		}

		public byte[] Payload
		{
			get;
			private set;
		}
		public ACDR(ACDRHeader Header, byte[] Payload)
		{
			if (Payload == null) throw new ArgumentNullException(nameof(Payload));
			this.Header = Header; this.Payload = Payload;

		}

	}
}
