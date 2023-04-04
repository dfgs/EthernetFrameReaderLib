using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct ACDRHeader
	{
		public byte Version
		{
			get;
			private set;
		}
		public uint TimeStamp
		{
			get;
			private set;
		}
		public ushort SequenceNumber 
		{
			get;
			private set;
		}
		public uint SourceID
		{
			get;
			private set;
		}
		public uint DestID
		{
			get;
			private set;
		}
		public byte ExtraData
		{
			get;
			private set;
		}
		public TracePoints TracePoint
		{
			get;
			private set;
		}
		public MediaTypes MediaType
		{
			get;
			private set;
		}
		public byte HeaderExtensionLength
		{
			get;
			private set;
		}
		
		public ACDRHeader(byte Version, uint TimeStamp, ushort SequenceNumber, uint SourceID, uint DestID, byte ExtraData, TracePoints TracePoint, MediaTypes MediaType, byte HeaderExtensionLength)
		{
			this.Version = Version;this.TimeStamp = TimeStamp;this.SequenceNumber=SequenceNumber;this.SourceID=SourceID;this.DestID=DestID;
			this.ExtraData=ExtraData;this.TracePoint=TracePoint;this.MediaType=MediaType;this.HeaderExtensionLength=HeaderExtensionLength;
			
		}
	}
}
