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
		public void ShouldNotReadUint16WhenEndOfBufferIsReached()
		{
			BigEndianReader reader;

			reader = new BigEndianReader(new byte[] { });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt16());
			
			reader = new BigEndianReader(new byte[] {0 });
			Assert.ThrowsException<InvalidOperationException>(() => reader.ReadUInt16());
		}

		[TestMethod]
		public void ShouldReadUint16()
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
		public void ShouldNotReadUint24WhenEndOfBufferIsReached()
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
		public void ShouldReadUint24()
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
		public void ShouldNotReadUint32WhenEndOfBufferIsReached()
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
		public void ShouldReadUint32()
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
		public void ShouldNotReadUint64WhenEndOfBufferIsReached()
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
		public void ShouldReadUint64()
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