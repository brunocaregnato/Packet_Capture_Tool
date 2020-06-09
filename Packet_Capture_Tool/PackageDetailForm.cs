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

                PopulateScreen(DetailPackagesList.Find(x => x.Id.Equals(int.Parse(packageId.Text))));
            }            
        }

        private void PopulateScreen(PackageDetail package)
        {
            checksumText.Text = package.TcpPacket.Checksum.ToString();
            ackText.Text = package.TcpPacket.Ack ? "Sim" : "Não";
            synText.Text = package.TcpPacket.Syn ? "Sim" : "Não";
            windowsSizeText.Text = package.TcpPacket.WindowSize.ToString();

            headerText.Text = "";
            foreach (var bytes in package.TcpPacket.Header)
            {
                headerText.Text += bytes.ToString().PadLeft(4, '0') + " ";
            }

            Console.WriteLine(package);

        }
    }
}
