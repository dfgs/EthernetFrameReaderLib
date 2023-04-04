using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthernetFrameReaderLib
{
	public enum Protocols {TCP = 6,UDP=17,ICMP=1}

	public enum EtherTypes {
		IPv4 = 0x0800,
		ARP = 0x0806,
		WOL = 0x0842,
		AVTP = 0x22F0,
		TRILL = 0x22F3,
		SRP = 0x22EA,
		DECMOPRC = 0x6002,
		DECnetDNA = 0x6003,
		DECLAT = 0x6004,
		RARP = 0x8035,
		Ethertalk = 0x809B,
		AARP = 0x80F3,
		VLANTagged = 0x8100,
		SLPP = 0x8102,
		VLACP = 0x8103,
		IPX = 0x8137,
		QNXQnet = 0x8204,
		IPv6 = 0x86DD,
		EthernetFlowControl = 0x8808,
		LACP = 0x8809,
		CobraNet = 0x8819,
		MPLSUnicast = 0x8847,
		MPLSMulticast = 0x8848,
		PPPoEDiscoveryStage = 0x8863,
		PPPoESessionStage = 0x8864,
		HomePlug = 0x887B,
		IEEE802dot1X = 0x888E,
		PROFINET = 0x8892,
		SCSIOverEthernet = 0x889A,
		ATAOverEthernet = 0x88A2,
		EtherCAT = 0x88A4,
		STag = 0x88A8,
		EthernetPowerlink = 0x88AB,
		GOOSE = 0x88B8,
		GSE = 0x88B9,
		SV = 0x88BA,
		MikroTikRoMON = 0x88BF,
		LLDP = 0x88CC,
		SERCOSIII = 0x88CD,
		HomePlugGreen = 0x88E1,
		IEC624392=0x88E3,
		MACsec = 0x88E5,
		PBB = 0x88E7,
		PTP = 0x88F7,
		NCSI = 0x88F8,
		PRP = 0x88FB,
		CFM = 0x8902,
		FCoE = 0x8906,
		FCoEInitializationProtocol = 0x8914,
		RoCE = 0x8915,
		TTE = 0x891D,
		IEEE = 0x893a,
		HSR = 0x892F,
		ECTP = 0x9000,
		RedundancyTag = 0xF1C1
	};

	public enum TracePoints { TCP = 6, UDP = 17, ICMP = 1 }
	public enum MediaTypes { TCP = 6, UDP = 17, ICMP = 1 }

}
