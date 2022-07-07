using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public interface ISegmentHeader
	{
		ushort SourcePort
		{
			get;
		}

		ushort DestinationPort
		{
			get;
		}
		
		ushort Checksum
		{
			get;
		}


		


	}
}
