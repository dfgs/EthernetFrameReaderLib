using System.Text;

namespace BigEndianReaderLib.UnitTest
{
	[TestClass]
	public class BigEndianReaderUnitTest
	{
		[TestMethod]
		public void ShouldCheckConstructor()
		{
			Assert.ThrowsException<ArgumentNullException>(() => new BigEndianReader(null));
		}

		[TestMethod]
		public void ShouldNotReadByteWhenEndOfBufferIsReached()
		{
			byte[] buffer = new byte[0];
			BigEndianReader reader;

			reader=new BigEndianReader(buffer);
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadByte());
		}
		[TestMethod]
		public void ShouldReadByte()
		{
			byte[] buffer=new byte[] {0,1, 2, 3};
			BigEndianReader reader;

			reader = new BigEndianReader(buffer);
			Assert.AreEqual(0, reader.ReadByte());
			Assert.AreEqual(1, reader.ReadByte());
			Assert.AreEqual(2, reader.ReadByte());
			Assert.AreEqual(3, reader.ReadByte());
		}

		[TestMethod]
		public void ShouldNotReadUInt16WhenEndOfBufferIsReached()
		{
			BigEndianReader reader;

			reader = new BigEndianReader(new byte[] { });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt16());
			
			reader = new BigEndianReader(new byte[] {0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt16());
		}

		[TestMethod]
		public void ShouldReadUInt16()
		{
			byte[] buffer = new byte[] {
				1, 0, 
				1, 1, 
				1, 2 ,
				1, 3 ,
			};
			BigEndianReader reader;

			reader = new BigEndianReader(buffer);
			Assert.AreEqual((ushort)256, reader.ReadUInt16());
			Assert.AreEqual((ushort)257, reader.ReadUInt16());
			Assert.AreEqual((ushort)258, reader.ReadUInt16());
			Assert.AreEqual((ushort)259, reader.ReadUInt16());
		}


		[TestMethod]
		public void ShouldNotReadUInt24WhenEndOfBufferIsReached()
		{
			BigEndianReader reader;

			reader = new BigEndianReader(new byte[] { });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt24());

			reader = new BigEndianReader(new byte[] { 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt24());
			
			reader = new BigEndianReader(new byte[] { 0 ,0});
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt24());
		}

		[TestMethod]
		public void ShouldReadUInt24()
		{
			byte[] buffer = new byte[] {
				1, 0, 0,
				1, 0, 1,
				1, 0, 2,
				1, 0, 3,
				1, 1, 0,
			};
			BigEndianReader reader;

			reader = new BigEndianReader(buffer);
			Assert.AreEqual(65536u, reader.ReadUInt24());
			Assert.AreEqual(65537u, reader.ReadUInt24());
			Assert.AreEqual(65538u, reader.ReadUInt24());
			Assert.AreEqual(65539u, reader.ReadUInt24());
			Assert.AreEqual(65792u, reader.ReadUInt24());
		}

		[TestMethod]
		public void ShouldNotReadUInt32WhenEndOfBufferIsReached()
		{
			BigEndianReader reader;

			reader = new BigEndianReader(new byte[] { });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt32());

			reader = new BigEndianReader(new byte[] { 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt32());

			reader = new BigEndianReader(new byte[] { 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt32());

			reader = new BigEndianReader(new byte[] { 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt32());
		}

		[TestMethod]
		public void ShouldReadUInt32()
		{
			byte[] buffer = new byte[] {
				1, 0, 0, 0,
				1, 0, 0, 1,
				1, 0, 0, 2,
				1, 0, 0, 3,
				1, 1, 0, 0,
				1, 1, 1, 0,
				1, 1, 1, 1,
			};
			BigEndianReader reader;

			reader = new BigEndianReader(buffer);
			Assert.AreEqual(16777216u, reader.ReadUInt32());
			Assert.AreEqual(16777217u, reader.ReadUInt32());
			Assert.AreEqual(16777218u, reader.ReadUInt32());
			Assert.AreEqual(16777219u, reader.ReadUInt32());
			Assert.AreEqual(16842752u, reader.ReadUInt32());
			Assert.AreEqual(16843008u, reader.ReadUInt32());
			Assert.AreEqual(16843009u, reader.ReadUInt32());
		}

		[TestMethod]
		public void ShouldNotReadUInt64WhenEndOfBufferIsReached()
		{
			BigEndianReader reader;

			reader = new BigEndianReader(new byte[] { });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt64());

			reader = new BigEndianReader(new byte[] { 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt64());

			reader = new BigEndianReader(new byte[] { 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt64());

			reader = new BigEndianReader(new byte[] { 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt64());

			reader = new BigEndianReader(new byte[] { 0, 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt64());

			reader = new BigEndianReader(new byte[] { 0, 0, 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt64());

			reader = new BigEndianReader(new byte[] { 0, 0, 0, 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt64());

			reader = new BigEndianReader(new byte[] { 0, 0, 0, 0, 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt64());
		}
		[TestMethod]
		public void ShouldReadUInt64()
		{
			byte[] buffer = new byte[] {
				0, 0, 0, 0, 1, 0, 0, 0,
				0, 0, 0, 0, 1, 0, 0, 1,
				0, 0, 0, 0, 1, 0, 0, 2,
				0, 0, 0, 0, 1, 0, 0, 3,
				0, 0, 0, 0, 1, 1, 0, 0,
				0, 0, 0, 0, 1, 1, 1, 0,
				0, 0, 0, 0, 1, 1, 1, 1,
			};
			BigEndianReader reader;

			reader = new BigEndianReader(buffer);
			Assert.AreEqual(16777216u, reader.ReadUInt64());
			Assert.AreEqual(16777217u, reader.ReadUInt64());
			Assert.AreEqual(16777218u, reader.ReadUInt64());
			Assert.AreEqual(16777219u, reader.ReadUInt64());
			Assert.AreEqual(16842752u, reader.ReadUInt64());
			Assert.AreEqual(16843008u, reader.ReadUInt64());
			Assert.AreEqual(16843009u, reader.ReadUInt64()); 

			
		}






		[TestMethod]
		public void ShouldNotReadInt16WhenEndOfBufferIsReached()
		{
			BigEndianReader reader;

			reader = new BigEndianReader(new byte[] { });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt16());

			reader = new BigEndianReader(new byte[] { 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt16());
		}

		[TestMethod]
		public void ShouldReadInt16()
		{
			byte[] buffer = new byte[] {
				0xFF, 0xFF,
				1, 1,
				1, 2 ,
				1, 3 ,
			};
			BigEndianReader reader;

			reader = new BigEndianReader(buffer);
			Assert.AreEqual((short)-1, reader.ReadInt16());
			Assert.AreEqual((short)257, reader.ReadInt16());
			Assert.AreEqual((short)258, reader.ReadInt16());
			Assert.AreEqual((short)259, reader.ReadInt16());
		}

	

		[TestMethod]
		public void ShouldNotReadInt32WhenEndOfBufferIsReached()
		{
			BigEndianReader reader;

			reader = new BigEndianReader(new byte[] { });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt32());

			reader = new BigEndianReader(new byte[] { 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt32());

			reader = new BigEndianReader(new byte[] { 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt32());

			reader = new BigEndianReader(new byte[] { 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt32());
		}

		[TestMethod]
		public void ShouldReadInt32()
		{
			byte[] buffer = new byte[] {
				0xFF, 0xFF, 0xFF, 0xFF,
				1, 0, 0, 1,
				1, 0, 0, 2,
				1, 0, 0, 3,
				1, 1, 0, 0,
				1, 1, 1, 0,
				1, 1, 1, 1,
			};
			BigEndianReader reader;

			reader = new BigEndianReader(buffer);
			Assert.AreEqual(-1, reader.ReadInt32());
			Assert.AreEqual(16777217, reader.ReadInt32());
			Assert.AreEqual(16777218, reader.ReadInt32());
			Assert.AreEqual(16777219, reader.ReadInt32());
			Assert.AreEqual(16842752, reader.ReadInt32());
			Assert.AreEqual(16843008, reader.ReadInt32());
			Assert.AreEqual(16843009, reader.ReadInt32());
		}

		[TestMethod]
		public void ShouldNotReadInt64WhenEndOfBufferIsReached()
		{
			BigEndianReader reader;

			reader = new BigEndianReader(new byte[] { });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt64());

			reader = new BigEndianReader(new byte[] { 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt64());

			reader = new BigEndianReader(new byte[] { 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt64());

			reader = new BigEndianReader(new byte[] { 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt64());

			reader = new BigEndianReader(new byte[] { 0, 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt64());

			reader = new BigEndianReader(new byte[] { 0, 0, 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt64());

			reader = new BigEndianReader(new byte[] { 0, 0, 0, 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt64());

			reader = new BigEndianReader(new byte[] { 0, 0, 0, 0, 0, 0, 0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadInt64());
		}
		[TestMethod]
		public void ShouldReadInt64()
		{
			byte[] buffer = new byte[] {
				0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
				0, 0, 0, 0, 1, 0, 0, 1,
				0, 0, 0, 0, 1, 0, 0, 2,
				0, 0, 0, 0, 1, 0, 0, 3,
				0, 0, 0, 0, 1, 1, 0, 0,
				0, 0, 0, 0, 1, 1, 1, 0,
				0, 0, 0, 0, 1, 1, 1, 1,
			};
			BigEndianReader reader;

			reader = new BigEndianReader(buffer);
			Assert.AreEqual(-1, reader.ReadInt64());
			Assert.AreEqual(16777217, reader.ReadInt64());
			Assert.AreEqual(16777218, reader.ReadInt64());
			Assert.AreEqual(16777219, reader.ReadInt64());
			Assert.AreEqual(16842752, reader.ReadInt64());
			Assert.AreEqual(16843008, reader.ReadInt64());
			Assert.AreEqual(16843009, reader.ReadInt64());


		}











		[TestMethod]
		public void ShouldNotReadStringWhenEndOfBufferIsReached()
		{
			byte[] buffer = new byte[3];
			BigEndianReader reader;

			reader = new BigEndianReader(buffer);
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadString(4,Encoding.ASCII));
		}

		[TestMethod]
		public void ShouldReadString()
		{
			byte[] buffer = Encoding.ASCII.GetBytes("abc");
			BigEndianReader reader;

			reader = new BigEndianReader(buffer);
			Assert.AreEqual("abc", reader.ReadString(3,Encoding.ASCII));
		}




	}
}