using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct TCPHeader
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
		public uint SequenceNumber
		{
			get;
			private set;
		}
		public uint AcknowledgmentNumber
		{
			get;
			private set;
		}

		public ushort HeaderLength
		{
			get;
			private set;
		}

		public TCPHeaderFlag Flag
		{
			get;
			private set;
		}

		public ushort Window
		{
			get;
			private set;
		}
		public ushort Checksum
		{
			get;
			private set;
		}

		public ushort UrgentPointer
		{
			get;
			private set;
		}


		public TCPHeader(ushort SourcePort,ushort DestinationPort, uint SequenceNumber, uint AcknowledgmentNumber, ushort HeaderLength,TCPHeaderFlag Flag, ushort Window, ushort Checksum, ushort UrgentPointer)
		{
			
			this.SourcePort = SourcePort;this.DestinationPort = DestinationPort;
			this.SequenceNumber = SequenceNumber;this.AcknowledgmentNumber = AcknowledgmentNumber;
			this.HeaderLength = HeaderLength;this.Flag = Flag;
			this.Window = Window;this.Checksum = Checksum;
			this.UrgentPointer = UrgentPointer;
		}


	}
}
