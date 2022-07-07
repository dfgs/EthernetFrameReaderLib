using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct IPAddress
	{
		private byte a,b,c,d;
		private string stringValue;

		public IPAddress(byte A, byte B, byte C, byte D)
		{
			this.a = A;this.b = B;this.c = C;this.d = D;
			stringValue = $"{a.ToString()}.{b.ToString()}.{c.ToString()}.{d.ToString()}";
		}

		public override string ToString()
		{
			return stringValue;
		}

	}
}
