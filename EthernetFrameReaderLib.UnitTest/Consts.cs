﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib.UnitTest
{
	internal static class Consts
	{
		private static FrameReader frameReader = new FrameReader();
		private static PacketReader packetReader = new PacketReader();

		public static byte[] FrameTooSmall = new byte[17];
		//		Frame 1
		public static byte[] Frame1 = new byte[] { 0, 28, 127, 59, 212, 79, 0, 80, 86, 130, 164, 3, 8, 0, 69, 0, 0, 40, 17, 164, 64, 0, 128, 6, 0, 0, 100, 90, 25, 13, 10, 17, 0, 95, 13, 61, 248, 169, 198, 62, 38, 236, 235, 176, 176, 61, 80, 16, 247, 121, 135, 241, 0, 0 };
		//		Frame 1866
		public static byte[] Frame2 = new byte[]  {0x00, 0x50, 0x56, 0x82, 0xa4, 0x03, 0x00, 0x1c,  0x7f, 0x3b, 0xd4, 0x4f, 0x08, 0x00, 0x45, 0x28,  0x00, 0x55, 0x00, 0x00, 0x00, 0x00, 0x6e, 0x11,  0x24, 0x8f, 0x64, 0x70, 0x46, 0x0a, 0x64, 0x5a,  0x19, 0x0d, 0x03, 0x9e, 0x03, 0x9d, 0x00, 0x41,  0x00, 0x00, 0x09, 0x3a, 0x9c, 0xfb, 0xee, 0x7e,  0xf2, 0x00, 0x00, 0x01, 0xf5, 0x00, 0x00, 0x01,  0xf5, 0x00, 0x15, 0x01, 0x09, 0xcd, 0x91, 0xeb,  0x1c, 0x00, 0x02, 0xd6, 0x2f, 0x29, 0x34, 0x72,  0x5d, 0xc7, 0xcc, 0x11, 0xd5, 0xb8, 0xb8, 0x80,  0x68, 0x14, 0x31, 0xf4, 0xd5, 0x69, 0xab, 0x3d,  0x2b, 0x16, 0x0f, 0xa7, 0x31, 0x50, 0x00, 0xd5,  0xe8, 0xf2, 0x3b};
		//		Frame 2
		public static byte[] Frame3 = { 0x00, 0x50, 0x56, 0x82, 0xa4, 0x03, 0x00, 0x1c,  0x7f, 0x3b, 0xd4, 0x4f, 0x08, 0x00, 0x45, 0x00,  0x00, 0x53, 0x05, 0x1f, 0x40, 0x00, 0x77, 0x06,  0x76, 0xaf, 0x0a, 0x11, 0x00, 0x5f, 0x64, 0x5a,  0x19, 0x0d, 0xf8, 0xa9, 0x0d, 0x3d, 0xeb, 0xb0,  0xb0, 0x3d, 0xc6, 0x3e, 0x26, 0xec, 0x50, 0x18,  0x02, 0x01, 0x32, 0x52, 0x00, 0x00, 0x17, 0x03,  0x03, 0x00, 0x26, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x1d, 0xef, 0xb6, 0xc6, 0x9f, 0xfe, 0x57,  0x9b, 0x9e, 0x10, 0x34, 0x7a, 0x6d, 0x16, 0xac,  0x78, 0x69, 0xd9, 0xb3, 0xf5, 0x7f, 0x7e, 0x8b,  0x73, 0x07, 0xaf, 0xe4, 0x40, 0x67, 0xb5, 0x3f,  0x54};


		public static byte[] PacketTooSmall = new byte[19];
		public static byte[] Packet1 = frameReader.Read(Frame1).Payload;
		public static byte[] Packet2 = frameReader.Read(Frame2).Payload;
		public static byte[] Packet3 = frameReader.Read(Frame3).Payload;

		public static byte[] TCPSegmentTooSmall = new byte[19];
		public static byte[] TCPSegment1 = packetReader.Read(Packet1).Payload;
		public static byte[] TCPSegment2 = packetReader.Read(Packet3).Payload;
	}
}
