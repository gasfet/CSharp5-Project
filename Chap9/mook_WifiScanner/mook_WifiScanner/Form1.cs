using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NativeWifi;
using System.Threading;

namespace mook_WifiScanner
{
    public partial class Form1 : Form
    {
        WlanClient wlanClient = new WlanClient();
        Thread thrAP;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thrAP = new Thread(ThreadList);
            thrAP.Start();
        }

        private void ThreadList()
        {
            while (true)
            {
                this.lvAP.Items.Clear();
                Wlan.WlanAvailableNetwork[] wlanBssEntries = 
                    wlanClient.Interfaces[0].GetAvailableNetworkList(0);
                foreach (Wlan.WlanAvailableNetwork network in wlanBssEntries)
                {
                    var lvt = new ListViewItem(new string[] { 
                        GetStringForSSID(network.dot11Ssid), 
                        network.wlanSignalQuality.ToString(), 
                        network.securityEnabled.ToString(), 
                        GetMacChanel(1, ConvertToMAC(network.dot11Ssid.SSID)), 
                        network.dot11DefaultCipherAlgorithm.ToString(), 
                        network.dot11DefaultAuthAlgorithm.ToString(), 
                        GetMacChanel(2, ConvertToMAC(network.dot11Ssid.SSID)) });
                    this.lvAP.Items.Add(lvt);
                }
                Thread.Sleep(10000);
            }
        }
        private string GetMacChanel(int i, string Name)
        {
            Wlan.WlanBssEntry[] lstWlanBss = 
                wlanClient.Interfaces[0].GetNetworkBssList();
            var reAP = "";
            foreach (var oWlan in lstWlanBss)
            {
                if (i == 2)
                {
                    if (ConvertToMAC(oWlan.dot11Ssid.SSID) == Name)
                    {
                        reAP = ConvertToMAC(oWlan.dot11Bssid);
                    }
                }
                else if (i == 1)
                {
                    if (ConvertToMAC(oWlan.dot11Ssid.SSID) == Name)
                    {
                        var chnl = oWlan.chCenterFrequency.ToString();
                        switch (chnl)
                        {
                            case "2412000":
                                reAP = "1";
                                break;
                            case "2417000":
                                reAP = "2";
                                break;
                            case "2422000":
                                reAP = "3";
                                break;
                            case "2427000":
                                reAP = "4";
                                break;
                            case "2432000":
                                reAP = "5";
                                break;
                            case "2437000":
                                reAP = "6";
                                break;
                            case "2442000":
                                reAP = "7";
                                break;
                            case "2447000":
                                reAP = "8";
                                break;
                            case "2452000":
                                reAP = "9";
                                break;
                            case "2457000":
                                reAP = "10";
                                break;
                            case "2462000":
                                reAP = "11";
                                break;
                            case "2467000":
                                reAP = "12";
                                break;
                            case "2472000":
                                reAP = "13";
                                break;
                        }
                    }

                }
            }
            return reAP;
        }
        string ConvertToMAC(byte[] MAC)
        {
            string strMAC = "";
            for (int index = 0; index < 6; index++)
                strMAC += MAC[index].ToString("X2") + "-";
            return strMAC.Substring(0, strMAC.Length - 1);
        }

        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 
                0, (int)ssid.SSIDLength);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.thrAP != null)
                thrAP.Abort();
            Application.ExitThread();
        }
    }
}
