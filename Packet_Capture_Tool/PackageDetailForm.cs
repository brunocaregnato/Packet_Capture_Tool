﻿using PacketDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packet_Capture_Tool
{
    public partial class PackageDetailForm : Form
    {
        private readonly List<PackageDetail> DetailPackagesList;
        

        public PackageDetailForm(List<PackageDetail> detailPackages)
        {
            DetailPackagesList = detailPackages;
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (packageId.TextLength.Equals(0)) return;
            else
            {
                int.TryParse(packageId.Text, out int correctParse);
                if (correctParse.Equals(0)) return;

                ClearScreen();
                PopulateScreen(DetailPackagesList.Find(x => x.Id.Equals(int.Parse(packageId.Text))));
            }            
        }

        private void PopulateScreen(PackageDetail package)
        {
            if(package == null)
            {
                MessageBox.Show("Package does not exist! Enter a valid package.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (package.TcpPacket != null)
            {
                packageType.Text = "TCP PACKET";
                headerText.Text = SetHeader(package.TcpPacket.Header);

                checksumText.Text += package.TcpPacket.Checksum.ToString() + " - is " + BooleanToString(package.TcpPacket.ValidChecksum, 1); 
                windowsSizeText.Text += package.TcpPacket.WindowSize.ToString();
                sequenceNumberText.Text += package.TcpPacket.SequenceNumber.ToString();
                acknowledgmentNumberText.Text += package.TcpPacket.AcknowledgmentNumber.ToString();
                dataOffsetText.Text += package.TcpPacket.DataOffset.ToString();

                sourceAndDestinationText.Text += SetAddress(package.IpPacket, package.TcpPacket);

                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.CWR) + " -> Congestion Window Reduced (CWR): " + BooleanToString(package.TcpPacket.CWR);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.ECN) + " -> ECN-Echo: " + BooleanToString(package.TcpPacket.ECN);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Urg) + " -> Urgent: " + BooleanToString(package.TcpPacket.Urg);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Ack) + " -> Acknowledgment: " + BooleanToString(package.TcpPacket.Ack);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Psh) + " -> Push: " + BooleanToString(package.TcpPacket.Psh);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Rst) + " -> Reset: " + BooleanToString(package.TcpPacket.Rst);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Syn) + " -> Syn: " + BooleanToString(package.TcpPacket.Syn);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Fin) + " -> Fin: " + BooleanToString(package.TcpPacket.Fin);

            }
            else if(package.UdpPacket != null)
            {
                packageType.Text = "UDP PACKET";
                headerText.Text = SetHeader(package.UdpPacket.Header);

                sourceAndDestinationText.Text += SetAddress(package.IpPacket, package.TcpPacket);

                checksumText.Text += package.UdpPacket.Checksum.ToString() + " - is " + BooleanToString(package.UdpPacket.ValidChecksum, 1);

                sourceAndDestinationText.Text += SetAddress(package.IpPacket, package.UdpPacket);

                windowsSizeText.Text = sequenceNumberText.Text = acknowledgmentNumberText.Text = dataOffsetText.Text = flagsText.Text = "";

            }
        }

        private string BooleanToString(bool isTrue, int returnStringType = 0)
        {
            switch (returnStringType)
            {
                case 0: 
                        return isTrue ? "Set" : "Not Set";
                case 1:
                default: 
                        return isTrue ? "valid" : "invalid";
            }             
        }

        private string SetHeader(byte[] header)
        {
            bool brokeLine = false;
            string headerText = "";
            foreach (var bytes in header)
            {
                headerText += bytes.ToString().PadLeft(4, '0') + " ";
                if (headerText.Count() > 100 && !brokeLine)
                {
                    headerText += "\n".PadRight(15, ' ');
                    brokeLine = true;
                }
            }

            return headerText;
        }

        private string SetAddress(IpPacket ip, dynamic package)
        {
            return  ip.SourceAddress.ToString() + ":" + package.SourcePort.ToString()
                    + " -> Destination: " + ip.DestinationAddress.ToString() + ":" + package.DestinationPort.ToString()
                    + " - IP Version: " + ip.Version; ;
        }

        private void ClearScreen()
        {
            headerText.Text = "Header: ";
            checksumText.Text = "Checksum: ";
            windowsSizeText.Text = "Windows Size: ";
            sequenceNumberText.Text = "Sequence Number: ";
            sourceAndDestinationText.Text = "Source: ";
            acknowledgmentNumberText.Text = "Acknowledgment Number: ";
            dataOffsetText.Text = "Data Offset: ";
            flagsText.Text = "------------------------------------------------------------------------------------> FLAGS <------------------------------------------------------------------------------------";
        }
    }
}
