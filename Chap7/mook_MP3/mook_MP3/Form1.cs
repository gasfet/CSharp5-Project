using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mook_MP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string strCurPos = "";
        private string strMP3FilePath = "";
        private string strMP3FileName = "";
        private string strMP3Length = "";
        private int intCurListPos = 0;
        MP3Play Mp3 = new MP3Play();
        List<string> MusicNamePath = new List<string>();

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            if (this.ofdMp3File.ShowDialog() == DialogResult.OK)
            {
                strMP3FilePath = this.ofdMp3File.FileName;
                strMP3FileName = Path.GetFileName(this.ofdMp3File.FileName);
                strMP3Length = Mp3.OpenFile(strMP3FilePath);
                AddFileList(strMP3FileName, strMP3FilePath, strMP3Length);
            }
        }
        private void AddFileList(string strMP3FileName, string strMP3FilePath, string strMP3Length)
        {
            var strCount = lvMp3List.Items.Count.ToString();
            var Musicinfo = new string[3] { strCount, strMP3FileName, strMP3Length };
            MusicNamePath.Add(strMP3FilePath);
            lvMp3List.Items.Add(new ListViewItem(Musicinfo));
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if ((Mp3.playStatus.Equals(Player_Status.Paused)))
            {
                Mp3.Play(strMP3FilePath);
                this.lblPlayResult.Text = "재   생";

                double trackCurPosition;
                trackCurPosition = Convert.ToDouble(this.PlayBar.Value
                    / Convert.ToDouble(PlayBar.Maximum)) * Mp3.Get_TotalDuration();
                Mp3.Set_CurPosition(trackCurPosition);
                return;
            }
            if (!(Mp3.playStatus.Equals(Player_Status.Running)))
            {
                if (this.lvMp3List.Items.Count < 1) return;
                if (this.lvMp3List.SelectedItems.Count < 1)
                    intCurListPos = 0;
                strMP3FilePath = MusicNamePath[Convert.ToInt32(lvMp3List.Items[intCurListPos].SubItems[0].Text)];
                Mp3.Play(strMP3FilePath);
                this.lblPlayResult.Text = "재   생";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (lvMp3List.Items.Count < 1) return;
            Mp3.PlayStop();
            this.lblPlayResult.Text = "정   지";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (lvMp3List.Items.Count < 1) return;
            Mp3.PlayPause();
            this.lblPlayResult.Text = "일시정지";
        }

        private void lvMp3List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvMp3List.SelectedItems.Count > 0)
                intCurListPos = this.lvMp3List.SelectedItems[0].Index;
        }

        private void lvMp3List_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvMp3List.SelectedItems.Count > 0)
            {
                Mp3.PlayStop();
                intCurListPos = this.lvMp3List.SelectedItems[0].Index;
                btnPlay_Click(sender, e);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Mp3.playStatus.Equals(Player_Status.Running))
            {
                if (this.PlayBar.Value > this.PlayBar.Maximum - 1)
                {
                    intCurListPos = intCurListPos + 1;
                    if (intCurListPos >= lvMp3List.Items.Count) intCurListPos = 0;
                    lvMp3List.Items[intCurListPos].Selected = true;
                    btnPlay_Click(sender, e);
                    Mp3.Set_AudioVolume(-10000 + this.VolumeBar.Value * 100);
                    Mp3.Set_AudioBalance(-10000 + this.BalanceBar.Value * 200);
                }
                TrackBarRun();
            }
        }

        private void TrackBarRun()
        {
            strCurPos = String.Format("{0}/{1}",
                Mp3.Convert_Position_To_Time(Convert.ToInt32(Mp3.Get_CurPosition())),
                Mp3.Convert_Position_To_Time(Convert.ToInt32(Mp3.Get_TotalDuration())));
            this.lblCurPos.Text = strCurPos;
            PlayBar.Value = Convert.ToInt32((Mp3.Get_CurPosition() * PlayBar.Maximum / Mp3.Get_TotalDuration()));
        }

        private void PlayBar_Scroll(object sender, EventArgs e)
        {
            double trackCurPosition;
            trackCurPosition = Convert.ToDouble(this.PlayBar.Value
                / Convert.ToDouble(PlayBar.Maximum)) * Mp3.Get_TotalDuration();
            Mp3.Set_CurPosition(trackCurPosition);
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            if (Mp3.playStatus.Equals(Player_Status.Running))
                Mp3.Set_AudioVolume(-10000 + this.VolumeBar.Value * 100);
        }

        private void BalanceBar_Scroll(object sender, EventArgs e)
        {
            if (Mp3.playStatus.Equals(Player_Status.Running))
            {
                Mp3.Set_AudioBalance(-10000 + this.BalanceBar.Value * 200);
                if ((-10000 + this.BalanceBar.Value * 200) < 0)
                    this.lblBalance.Text = " Left : " +
                        (int)(-10000 + this.BalanceBar.Value * 200) / 100;
                else if ((-10000 + this.BalanceBar.Value * 200) == 0)
                    this.lblBalance.Text = "L = R ";
                else if ((-10000 + this.BalanceBar.Value * 200) > 0)
                    this.lblBalance.Text = "Right " +
                        (int)(-10000 + this.BalanceBar.Value * 200) / 100;
            }
        }
    }
}
