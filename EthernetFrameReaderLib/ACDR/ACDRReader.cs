using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public class ACDRReader : IACDRReader
	{
		public ACDR Read(byte[] Data)
		{
			ACDRHeader header;

			byte version;
			uint timeStamp;
			ushort sequenceNumber;
			uint sourceID,destID;
			byte extraData; 
			TracePoints tracePoint;
			MediaTypes mediaType;
			byte headerExtensionLength;


			byte[] payload;

			if (Data == null) throw new ArgumentNullException(nameof(Data));
			if (Data.Length<19) throw new ArgumentOutOfRangeException(nameof(Data));

			version = Data[0];
			timeStamp = (uint)((Data[1] << 3) + (Data[2] << 2) + (Data[3] << 1) + (Data[4]));
			sequenceNumber = (ushort)((Data[5] << 1) + (Data[6]));
			sourceID = (uint)((Data[7] << 3) + (Data[8] << 2) + (Data[9] << 1) + (Data[10]));
			destID = (uint)((Data[11] << 3) + (Data[12] << 2) + (Data[13] << 1) + (Data[14]));
			extraData = Data[15];

			try
			{
				tracePoint = (TracePoints)Data[16];
			}
			catch (Exception)
			{
				throw new ArgumentOutOfRangeException("Invalid trace point");
			}
			try
			{
				mediaType = (MediaTypes)Data[17];
			}
			catch (Exception)
			{
				throw new ArgumentOutOfRangeException("Invalid media type");
			}

			headerExtensionLength = Data[18];

			header= new ACDRHeader(version,timeStamp,sequenceNumber,sourceID,destID,extraData,tracePoint,mediaType,headerExtensionLength);

			payload = Data.Skip(19).Take(Data.Length - 19).ToArray();

			return new ACDR(header,payload);


		}




	}
}
