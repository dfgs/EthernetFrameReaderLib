using System.Text;

namespace BigEndianReaderLib
{
	public interface IBigEndianReader
	{
		int Position
		{
			get;
		}
		int Length
		{
			get;
		}

		byte ReadByte();
		ushort ReadUInt16();
		uint ReadUInt24();
		uint ReadUInt32();
		ulong ReadUInt64();
		short ReadInt16();
		int ReadInt32();
		long ReadInt64();
		byte[] ReadBytes(int Count);

		string ReadString(int Length,Encoding Encoding);
	}
}