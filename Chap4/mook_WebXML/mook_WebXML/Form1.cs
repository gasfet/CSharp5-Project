using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; //WebClient 클래스 사용
using System.Xml; // XmlDocument, XmlNodeList 클래스 사용
using System.IO; //StringReader 클래스 사용
using System.Threading;
using System.Diagnostics;

namespace mook_WebXML
{
    public partial class Form1 : Form
    {
        const string headerURL = "http://localhost/"; // 주소 저장
        string WeatherURL = "http://www.kma.go.kr/XML/weather/sfc_web_map.xml"; //주소저장
        Dictionary<string, string> news = new Dictionary<string, string>();
        Thread NewcheckThread; //스레드 개체 생성

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lvFile.Items.Clear();

            WebClient wc = new WebClient();
            string buffer = wc.DownloadString(string.Format("{0}WebXml.xml", headerURL));
            wc.Dispose();

            StringReader sr = new StringReader(buffer);
            XmlDocument doc = new XmlDocument();
            doc.Load(sr);
            sr.Close();

            XmlNodeList forecastNodes = doc.SelectNodes("xml_reply/human/human_entry");

            foreach (XmlNode node in forecastNodes)
            {
                this.lvFile.Items.Add(new ListViewItem(new String[] { GetNodeValue(node, "title") }));
            }
        }
        private string GetNodeValue(XmlNode parent, string name)
        {
            try
            {
                XmlAttribute attr = parent.SelectSingleNode(name).Attributes["name"];
                if (attr != null)
                    return attr.Value;
                return null;
            }
            catch
            {
                return null;
            }
        }

        private void GetNews()
        {
            try { 
                XmlDocument XMLDoc = new XmlDocument();
                XMLDoc.Load(WeatherURL);
                XmlNode nd = XMLDoc.DocumentElement;
                foreach (XmlNode node in nd.FirstChild.ChildNodes)
                {
                    news.Add("지역 : " + node.InnerText + " / " + node.Attributes["desc"].Value + " / "
                        + node.Attributes["ta"].Value, "http://www.kma.go.kr/weather/main_all.jsp?stncd="
                        + node.Attributes["stn_id"].Value);
                    this.ttipMemo.SetToolTip(lklblNews, "지역 날씨 상세보기");
                }
            }
            catch { return; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetNews();
            NewcheckThread = new Thread(DisplayNews);
            NewcheckThread.Start();
        }

        private void DisplayNews()
        {
            while(true)
            {
                foreach(KeyValuePair<string, string> newstitle in news)
                {
                    this.lklblNews.Text = newstitle.Key;
                    this.lklblNews.AccessibleDescription = newstitle.Value;
                    Thread.Sleep(3000);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(NewcheckThread == null))
            {
                NewcheckThread.Abort();
                this.Dispose();   
            }
        }

        private void lklblNews_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = this.lklblNews.AccessibleDescription;
            myProcess.Start();
        }
    }
}