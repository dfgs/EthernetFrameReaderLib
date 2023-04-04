using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct BoardID
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

		public BoardID(byte A, byte B, byte C)
		{
			this.A = A;this.B = B;this.C = C;
		}

		public override string ToString()
		{
			return String.Format("{0:X2}{1:X2}{2:X2}", A, B,C);
		}

	}
}
