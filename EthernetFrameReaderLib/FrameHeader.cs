using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct FrameHeader
	{
		public MACAddress SourceAddress
		{
			get;
			private set;
		}
		public MACAddress DestinationAddress
		{
			get;
			private set;
		}
		public EtherTypes EtherType
		{
			get;
			private set;
		}
		public FrameHeader(MACAddress SourceAddress,MACAddress DestinationAddress, EtherTypes EtherType)
		{
			this.SourceAddress = SourceAddress;this.DestinationAddress = DestinationAddress; this.EtherType = EtherType;
		}

	}
}
