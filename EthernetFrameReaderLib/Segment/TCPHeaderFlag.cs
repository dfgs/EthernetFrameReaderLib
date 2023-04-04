using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct TCPHeaderFlag
	{
		public bool ECN
		{
			get;
			private set;
		}
		public bool CWR
		{
			get;
			private set;
		}
		public bool ECE
		{
			get;
			private set;
		}
		public bool URG
		{
			get;
			private set;
		}
		public bool ACK
		{
			get;
			private set;
		}
		public bool PSH
		{
			get;
			private set;
		}
		public bool RST
		{
			get;
			private set;
		}
		public bool SYN
		{
			get;
			private set;
		}
		public bool FIN
		{
			get;
			private set;
		}
		public TCPHeaderFlag(bool ECN, bool CWR, bool ECE, bool URG, bool ACK, bool PSH, bool RST, bool SYN, bool FIN)
		{
			this.ECN = ECN;this.CWR= CWR;this.ECE = ECE;this.URG = URG;this.ACK = ACK;this.PSH = PSH;this.RST = RST; this.SYN = SYN;this.FIN = FIN;
		}


	}
}
