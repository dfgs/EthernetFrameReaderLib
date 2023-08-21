using System.Text;

namespace BigEndianReaderLib
{
	public interface IBigEndianReader
	{
		byte ReadByte();
		ushort ReadUInt16();
		uint ReadUInt24();
		uint ReadUInt32();
		ulong ReadUInt64();

		string ReadString(int Length,Encoding Encoding);
	}
}