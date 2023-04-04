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
		public byte HeaderLength
		{
			get;
			private set;
		}



		public ACDRHeader(byte Version,byte HeaderLength)
		{
			
			this.Version = Version;this.HeaderLength = HeaderLength;
		}
	}
}
