using PacketDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Packet_Capture_Tool
{
    public class PackageDetail
    {
        public int Id { get; private set; }

        public UdpPacket UdpPacket { get; private set; }

        public TcpPacket TcpPacket { get; private set; }

        private static int _newId;

        public PackageDetail()
        {
            _newId = 0;
        }

        public PackageDetail(TcpPacket tcpPacket, UdpPacket udpPacket)
        {
            Id = Interlocked.Increment(ref _newId);
            TcpPacket = tcpPacket;
            UdpPacket = udpPacket;
        }



    }
}
