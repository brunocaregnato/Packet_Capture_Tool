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
            bool brokeLine = false;

            if (package.TcpPacket != null)
            {
                foreach (var bytes in package.TcpPacket.Header)
                {
                    headerText.Text += bytes.ToString().PadLeft(4, '0') + " ";
                    if(headerText.Text.Count() > 100 && !brokeLine)
                    {
                        headerText.Text += "\n".PadRight(15, ' ');
                        brokeLine = true;
                    }
                }

                checksumText.Text += package.TcpPacket.Checksum.ToString();
                windowsSizeText.Text += package.TcpPacket.WindowSize.ToString();
                sequenceNumberText.Text += package.TcpPacket.SequenceNumber.ToString();
                acknowledgmentNumberText.Text += package.TcpPacket.AcknowledgmentNumber.ToString();
                dataOffsetText.Text += package.TcpPacket.DataOffset.ToString();

                sourceAndDestinationText.Text += package.IpPacket.SourceAddress.ToString() + ":" + package.TcpPacket.SourcePort.ToString() 
                    + " -> Destination: " + package.IpPacket.DestinationAddress.ToString() + ":" + package.TcpPacket.DestinationPort.ToString();

                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.CWR) + " -> Congestion Window Reduced (CWR): " + BooleanToString(package.TcpPacket.CWR, true);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.ECN) + " -> ECN-Echo: " + BooleanToString(package.TcpPacket.ECN, true);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Urg) + " -> Urgent: " + BooleanToString(package.TcpPacket.Urg, true);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Ack) + " -> Acknowledgment: " + BooleanToString(package.TcpPacket.Ack, true);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Psh) + " -> Push: " + BooleanToString(package.TcpPacket.Psh, true);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Rst) + " -> Reset: " + BooleanToString(package.TcpPacket.Rst, true);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Syn) + " -> Syn: " + BooleanToString(package.TcpPacket.Syn, true);
                flagsText.Text += "\n" + BooleanToString(package.TcpPacket.Fin) + " -> Fin: " + BooleanToString(package.TcpPacket.Fin, true);

            }
        }

        private string BooleanToString(bool isTrue, bool returnString = false)
        {
            if (returnString)
                return isTrue ? "Set" : "Not Set";

            return isTrue ? "1" : "0";
        }

        private void ClearScreen()
        {
            headerText.Text = "Header: ";
            checksumText.Text = "Checksum: ";
            windowsSizeText.Text = "Windows Size: ";
            sequenceNumberText.Text = "Sequence Number: ";
            sourceAndDestinationText.Text = "Source: ";
            acknowledgmentNumberText.Text = "Acknowledgment Number: ";
            acknowledgmentNumberText.Text = "Data Offset: ";
            flagsText.Text = "------------------------------------------------------------------------------------> FLAGS <------------------------------------------------------------------------------------";
        }
    }
}
