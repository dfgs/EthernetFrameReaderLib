using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct SessionID
	{
		public byte A
		{
			get;
			private set;
		}
		public byte B
		{
			get;
			private set;
		}
		public byte C
		{
			get;
			private set;
		}
		public byte D
		{
			get;
			private set;
		}
		public byte E
		{
			get;
			private set;
		}
		public SessionID(byte A, byte B, byte C, byte D, byte E)
		{
			this.A = A;this.B = B;this.C = C;this.D = D;this.E = E;
		}

		public override string ToString()
		{
			ulong value;
			value = ((ulong)A << 32) + ((ulong)B << 24) +( (ulong)C << 16) + ((ulong)D << 8) +( (ulong)E );
			return  value.ToString();
		}

	}
}
