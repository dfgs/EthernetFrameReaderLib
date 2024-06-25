using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigEndianReaderLib
{
	public class BigEndianReader : IBigEndianReader
	{
		private int position;
		private byte[] buffer;

		public BigEndianReader(byte[] Buffer) 
		{ 
			if (Buffer == null) throw new ArgumentNullException(nameof(Buffer));	
			this.buffer = Buffer;
			this.position= 0;
		}

		public byte ReadByte()
		{
			if (position >= buffer.Length) throw new InvalidOperationException("End of buffer reached");
			return buffer[position++];
		}

		public ushort ReadUInt16()
		{
			if (position >= buffer.Length-1) throw new InvalidOperationException("End of buffer reached");
			return (ushort)((ushort)(buffer[position++] << 8) + (ushort)buffer[position++]);
		}

		public uint ReadUInt24()
		{
			if (position >= buffer.Length - 2) throw new InvalidOperationException("End of buffer reached");
			return (((uint)buffer[position++] << 16)+ ((uint)buffer[position++] << 8) + (uint)buffer[position++]);
		}

		public uint ReadUInt32()
		{
			if (position >= buffer.Length - 3) throw new InvalidOperationException("End of buffer reached");
			return (((uint)buffer[position++] << 24) + ((uint)buffer[position++] << 16) + ((uint)buffer[position++] << 8) + (uint)buffer[position++]);
		}

		public ulong ReadUInt64()
		{
			if (position >= buffer.Length - 7) throw new InvalidOperationException("End of buffer reached");
			return ( ((ulong)buffer[position++] << 56) + ((ulong)buffer[position++] << 48) + ((ulong)buffer[position++] << 40) + ((ulong)buffer[position++] << 32) + ((ulong)buffer[position++] << 24) + ((ulong)buffer[position++] << 16) + ((ulong)buffer[position++] << 8) + (ulong)buffer[position++]);
		}
		public short ReadInt16()
		{
			if (position >= buffer.Length - 1) throw new InvalidOperationException("End of buffer reached");
			return (short)((ushort)(buffer[position++] << 8) + (ushort)buffer[position++]);
		}

		
		public int ReadInt32()
		{
			if (position >= buffer.Length - 3) throw new InvalidOperationException("End of buffer reached");
			return (int)(((uint)buffer[position++] << 24) + ((uint)buffer[position++] << 16) + ((uint)buffer[position++] << 8) + (uint)buffer[position++]);
		}

		public long ReadInt64()
		{
			if (position >= buffer.Length - 7) throw new InvalidOperationException("End of buffer reached");
			return (long)(((ulong)buffer[position++] << 56) + ((ulong)buffer[position++] << 48) + ((ulong)buffer[position++] << 40) + ((ulong)buffer[position++] << 32) + ((ulong)buffer[position++] << 24) + ((ulong)buffer[position++] << 16) + ((ulong)buffer[position++] << 8) + (ulong)buffer[position++]);
		}
		public string ReadString(int Length, Encoding Encoding)
		{
			string value;
			if (position > buffer.Length - Length) throw new InvalidOperationException("End of buffer reached");
			value=Encoding.GetString( buffer.Skip(position).Take(Length).ToArray());
			position += Length;
			return value;
		}


	}
}
