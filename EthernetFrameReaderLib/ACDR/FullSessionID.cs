using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public struct FullSessionID
	{
		public BoardID BoardID
		{
			get;
			private set;
		}
		public byte ResetCounter
		{
			get;
			private set;
		}
		public SessionID SessionID
		{
			get;
			private set;
		}

		public FullSessionID(BoardID BoardID,byte ResetCounter,SessionID SessionID)
		{
			this.BoardID = BoardID;this.ResetCounter= ResetCounter;this.SessionID= SessionID;
		}

		public override string ToString()
		{
			return $"{BoardID}:{ResetCounter}:{SessionID}";
		}

	}
}
