using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct MACAddress
	{
		private byte a,b,c,d,e,f;
		private string stringValue;

		public MACAddress(byte A, byte B, byte C, byte D, byte E, byte F)
		{
			this.a = A;this.b = B;this.c = C;this.d = D;this.e = E;this.f=F ;
			stringValue = $"{a.ToString("X2")}:{b.ToString("X2")}:{c.ToString("X2")}:{d.ToString("X2")}:{e.ToString("X2")}:{f.ToString("X2")}";
		}

		public override string ToString()
		{
			return stringValue;
		}

	}
}
