using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct TypeOfService
	{
		public byte DSCP
		{
			get;
			private set;
		}
		public byte ECN
		{
			get;
			private set;
		}

		public TypeOfService(byte DSCP,byte ECN)
		{
			this.DSCP = DSCP;this.ECN = ECN;
		}

	}
}
