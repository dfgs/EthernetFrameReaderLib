﻿using System.Text;

namespace BigEndianReaderLib
{
	public interface IBigEndianReader
	{
		byte ReadByte();
		ushort ReadUInt16();
		uint ReadUInt24();
		uint ReadUInt32();
		ulong ReadUInt64();
		short ReadInt16();
		int ReadInt32();
		long ReadInt64();

		string ReadString(int Length,Encoding Encoding);
	}
}