using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct PacketHeader
	{
		public byte Version
		{
			get;
			private set;
		}
		public byte HeaderLength
		{
			get;
			private set;
		}

		public TypeOfService TypeOfService
		{
			get;
			private set;
		}
		
		public ushort TotalLength
		{
			get;
			private set;
		}

		public ushort Identification	// permet de repérer les fragments d'un même paquets
		{
			get;
			private set;
		}

		public bool DontFragment
		{
			get;
			private set;
		}
		public bool MoreFragments
		{
			get;
			private set;
		}

		public ushort FragmentOffset
		{
			get;
			private set;
		}

		public byte TTL
		{
			get;
			private set;
		}

		public Protocols Protocol
		{
			get;
			private set;
		}

		public ushort HeaderChecksum
		{
			get;
			private set;
		}

		public IPAddress SourceAddress
		{
			get;
			private set;
		}
		public IPAddress DestinationAddress
		{
			get;
			private set;
		}

		public byte[] Padding
		{
			get;
			private set;
		}

		public PacketHeader(byte Version,byte HeaderLength,TypeOfService TypeOfService, ushort TotalLength, ushort Identification, bool DontFragment, bool MoreFragments,
			ushort FragmentOffset,byte TTL,Protocols Protocol, ushort HeaderChecksum,
			IPAddress SourceAddress,IPAddress DestinationAddress, byte[] Padding)
		{
			
			this.Version = Version;this.HeaderLength = HeaderLength;this.TypeOfService = TypeOfService;
			this.TotalLength = TotalLength;this.Identification = Identification;
			this.DontFragment = DontFragment;this.MoreFragments = MoreFragments;
			this.FragmentOffset = FragmentOffset;this.TTL = TTL;
			this.Protocol = Protocol;this.HeaderChecksum = HeaderChecksum;
			this.SourceAddress = SourceAddress;this.DestinationAddress = DestinationAddress;
			if (Padding == null) this.Padding = new byte[0]; else  this.Padding = Padding;
		}
	}
}
