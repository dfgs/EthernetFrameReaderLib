using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public interface IACDRReader
	{
		ACDR Read(byte[] Data);
	}
}
